using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Blun.ContentSecurityPolicy.AspNetCore
{
    public sealed class ContentSecurityPolicyMiddleware
    {
        private readonly HandleHeader _handleHeader;
        private readonly RequestDelegate _next;

        public ContentSecurityPolicyMiddleware(
            RequestDelegate next,
            ContentSecurityPolicyOptions contentSecurityPolicyOptions
            )
        {
            _next = next;
            _handleHeader = new HandleHeader(contentSecurityPolicyOptions);
        }

        public async Task Invoke(HttpContext context)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            var headers = context.Response.Headers;
            if (headers.ContainsKey(_handleHeader.GetHeaderName))
            {
                headers.Remove(_handleHeader.GetHeaderName);
            }
            if (!string.IsNullOrWhiteSpace(_handleHeader.GetHeaderValue()))
            {
                headers.Add(_handleHeader.GetHeaderName, _handleHeader.GetHeaderValue());
            }

            await _next(context).ConfigureAwait(false);
        }

    }
}