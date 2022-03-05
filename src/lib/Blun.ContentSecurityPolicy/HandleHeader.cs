using System;
using System.Collections.Generic;
using System.Text;

namespace Blun.ContentSecurityPolicy
{
    public sealed class HandleHeader
    {
        private const string Header = "Content-Security-Policy";
        private static string _cache = string.Empty;
        private static bool _isCacheActive = false;
        private static readonly object LockObject = new object();
        private readonly ContentSecurityPolicyOptions _contentSecurityPolicyOptions;

        public HandleHeader(ContentSecurityPolicyOptions contentSecurityPolicyOptions)
        {
            _contentSecurityPolicyOptions = contentSecurityPolicyOptions;
        }

        public string GetHeaderName => Header;

        public string GetHeaderValue()
        {
            if (_isCacheActive) return _cache;

            lock (LockObject)
            {
                if (_isCacheActive) return _cache;

                _cache = _contentSecurityPolicyOptions.CreateCspHeaderValue();
                _isCacheActive = true;
            }

            return _cache;
        }
    }
}
