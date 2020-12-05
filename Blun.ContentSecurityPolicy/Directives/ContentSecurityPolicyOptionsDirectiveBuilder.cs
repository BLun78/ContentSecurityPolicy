using System;
using System.Collections.Generic;
using Blun.ContentSecurityPolicy.Directives.Values;

namespace Blun.ContentSecurityPolicy.Directives
{
    public abstract class ContentSecurityPolicyOptionsDirectiveBuilder
    {
        protected internal List<string> Sources { get; set; }

        protected ContentSecurityPolicyOptionsDirectiveBuilder()
        {
            Sources = new List<string>();
        }

        protected internal ContentSecurityPolicyOptionsDirectiveBuilder AllowSelf() => Allow("'self'");
        protected internal ContentSecurityPolicyOptionsDirectiveBuilder AllowUnsafeInline() => Allow("'unsafe-inline'");
        protected internal ContentSecurityPolicyOptionsDirectiveBuilder AllowUnsafeEval() => Allow("'unsafe-eval'");
        protected internal ContentSecurityPolicyOptionsDirectiveBuilder AllowUnsafeHashes() => Allow("'unsafe-hashes'");
        protected internal ContentSecurityPolicyOptionsDirectiveBuilder AllowStrictDynamic() => Allow("'strict-dynamic'");
        protected internal ContentSecurityPolicyOptionsDirectiveBuilder AllowReportSample() => Allow("'report-sample'");
        protected internal ContentSecurityPolicyOptionsDirectiveBuilder AllowSchemeSourceHttp() => Allow("http:");
        protected internal ContentSecurityPolicyOptionsDirectiveBuilder AllowSchemeSourceHttps() => Allow("https:");
        protected internal ContentSecurityPolicyOptionsDirectiveBuilder AllowSchemeSourceData() => Allow("data:");
        protected internal ContentSecurityPolicyOptionsDirectiveBuilder AllowSchemeSourceMediaStream() => Allow("mediastream:");
        protected internal ContentSecurityPolicyOptionsDirectiveBuilder AllowSchemeSourceBlob() => Allow("blob:");
        protected internal ContentSecurityPolicyOptionsDirectiveBuilder AllowSchemeSourceFilesystem() => Allow("filesystem:");
        protected internal ContentSecurityPolicyOptionsDirectiveBuilder AllowNone() => Allow("none");
        protected internal ContentSecurityPolicyOptionsDirectiveBuilder AllowAny() => Allow("*");

        protected internal ContentSecurityPolicyOptionsDirectiveBuilder AllowNonce(string base64HashValue)
        {
            if (string.IsNullOrWhiteSpace(base64HashValue))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(base64HashValue));

            if (!IsBase64String(base64HashValue))
                throw new FormatException($"The parameter {base64HashValue} is not a Bas64 string!");

            return Allow($"'nonce-{base64HashValue}'");
        }

        protected internal ContentSecurityPolicyOptionsDirectiveBuilder AllowHash(HashDirective hash, string base64HashValue)
        {
            if (string.IsNullOrWhiteSpace(base64HashValue))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(base64HashValue));

            if (!IsBase64String(base64HashValue))
                throw new FormatException($"The parameter {base64HashValue} is not a Bas64 string!");

            switch (hash)
            {
                case HashDirective.SHA256:
                    return Allow($"'SHA256-{base64HashValue}'");
                case HashDirective.SHA384:
                    return Allow($"'SHA384-{base64HashValue}'");
                case HashDirective.SHA512:
                    return Allow($"'SHA512-{base64HashValue}'");
                default:
                    throw new NotSupportedException($"The Hash [{hash.ToString()}] is not supported now!");
            }
        }

        protected internal ContentSecurityPolicyOptionsDirectiveBuilder AllowUnsafeEval(bool isDev)
        {
            if (isDev)
            {
                Allow("'unsafe-eval'");
            }

            return this;
        }

        protected internal ContentSecurityPolicyOptionsDirectiveBuilder Allow(string source)
        {
            this.Sources.Add(source);
            return this;
        }

        public static bool IsBase64String(string base64)
        {
            return true;
        }
    }
}
