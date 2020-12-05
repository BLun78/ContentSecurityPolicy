using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Blun.ContentSecurityPolicy.AspNetCore
{
    public sealed class ContentSecurityPolicyMiddleware
    {
        private const string Header = "Content-Security-Policy";
        private static string _cache = string.Empty;
        private static bool _isCacheActive = false;
        private static readonly object LockObject = new object();
        private readonly RequestDelegate _next;
        private readonly ContentSecurityPolicyOptions _contentSecurityPolicyOptions;

        public ContentSecurityPolicyMiddleware(
            RequestDelegate next,
            ContentSecurityPolicyOptions options
            )
        {
            _next = next;
            _contentSecurityPolicyOptions = options;
        }

        public async Task Invoke(HttpContext context)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            var headers = context.Response.Headers;
            if (!headers.ContainsKey(Header))
            {
                headers.Add(Header, GetHeaderValue());
            }
            else
            {
                headers.Remove(Header);
                headers.Add(Header, GetHeaderValue());
            }
            await _next(context).ConfigureAwait(false);
        }

        private string GetHeaderValue()
        {
            if (_isCacheActive) return _cache;

            lock (LockObject)
            {
                if (_isCacheActive) return _cache;

                _cache = CreateCspHeaderValue();
                _isCacheActive = true;
            }

            return _cache;
        }

        private string CreateCspHeaderValue()
        {
            var value = "";
            value += GetDirective("default-src", _contentSecurityPolicyOptions.Defaults);
            value += GetDirective("script-src", _contentSecurityPolicyOptions.Scripts);
            value += GetDirective("style-src", _contentSecurityPolicyOptions.Styles);
            value += GetDirective("img-src", _contentSecurityPolicyOptions.Images);
            value += GetDirective("font-src", _contentSecurityPolicyOptions.Fonts);
            value += GetDirective("media-src", _contentSecurityPolicyOptions.Media);
            return value;
        }

        private static string GetDirective(string directive, List<string> sources)
            => sources.Count > 0 ? $"{directive} {string.Join(" ", sources)}; " : "";
    }
}