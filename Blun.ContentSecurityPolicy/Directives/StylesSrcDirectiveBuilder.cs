using System;
using System.Collections.Generic;
using System.Text;
using Blun.ContentSecurityPolicy.Directives.Values;

namespace Blun.ContentSecurityPolicy.Directives
{
    public sealed class StylesSrcDirectiveBuilder :
        ContentSecurityPolicyOptionsDirectiveBuilder,
        IAllow<DefaultSrcDirectiveBuilder>,
        IAllowSchemeSourceHttp<DefaultSrcDirectiveBuilder>,
        IAllowSchemeSourceHttps<DefaultSrcDirectiveBuilder>,
        IAllowSelf<DefaultSrcDirectiveBuilder>,
        IAllowUnsafeEval<DefaultSrcDirectiveBuilder>,
        IAllowUnsafeHashes<DefaultSrcDirectiveBuilder>,
        IAllowUnsafeInline<DefaultSrcDirectiveBuilder>,
        IAllowNone<DefaultSrcDirectiveBuilder>,
        IAllowNonce<DefaultSrcDirectiveBuilder>,
        IAllowHash<DefaultSrcDirectiveBuilder>
    {
        public new DefaultSrcDirectiveBuilder AllowSelf() => (DefaultSrcDirectiveBuilder)base.AllowSelf();
        public new DefaultSrcDirectiveBuilder AllowUnsafeInline() => (DefaultSrcDirectiveBuilder)base.AllowUnsafeInline();
        public new DefaultSrcDirectiveBuilder AllowUnsafeEval() => (DefaultSrcDirectiveBuilder)base.AllowUnsafeEval();
        public new DefaultSrcDirectiveBuilder AllowUnsafeEval(bool isDev) => (DefaultSrcDirectiveBuilder)base.AllowUnsafeEval(isDev);
        public new DefaultSrcDirectiveBuilder Allow(string source) => (DefaultSrcDirectiveBuilder)base.Allow(source);
        public new DefaultSrcDirectiveBuilder AllowNone() => (DefaultSrcDirectiveBuilder)base.AllowNone();
        public new DefaultSrcDirectiveBuilder AllowUnsafeHashes() => (DefaultSrcDirectiveBuilder)base.AllowUnsafeHashes();
        public new DefaultSrcDirectiveBuilder AllowHash(HashDirective hash, string base64HashValue) => (DefaultSrcDirectiveBuilder)base.AllowHash(hash, base64HashValue);
        public new DefaultSrcDirectiveBuilder AllowNonce(string base64HashValue) => (DefaultSrcDirectiveBuilder)base.AllowNonce(base64HashValue);
        public new DefaultSrcDirectiveBuilder AllowSchemeSourceHttp() => (DefaultSrcDirectiveBuilder)base.AllowSchemeSourceHttp();
        public new DefaultSrcDirectiveBuilder AllowSchemeSourceHttps() => (DefaultSrcDirectiveBuilder)base.AllowSchemeSourceHttps();
    }
}
