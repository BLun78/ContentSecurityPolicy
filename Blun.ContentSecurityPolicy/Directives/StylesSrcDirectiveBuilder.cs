using System;
using System.Collections.Generic;
using System.Text;
using Blun.ContentSecurityPolicy.Directives.Values;

namespace Blun.ContentSecurityPolicy.Directives
{
    public sealed class StylesSrcDirectiveBuilder :
        ContentSecurityPolicyOptionsDirectiveBuilder,
        IAllow<StylesSrcDirectiveBuilder>,
        IAllowSchemeSourceHttp<StylesSrcDirectiveBuilder>,
        IAllowSchemeSourceHttps<StylesSrcDirectiveBuilder>,
        IAllowSchemeSourceData<StylesSrcDirectiveBuilder>,
        IAllowSchemeSourceMediaStream<StylesSrcDirectiveBuilder>,
        IAllowSchemeSourceBlob<StylesSrcDirectiveBuilder>,
        IAllowSchemeSourceFilesystem<StylesSrcDirectiveBuilder>,
        IAllowAny<StylesSrcDirectiveBuilder>,
        IAllowSelf<StylesSrcDirectiveBuilder>,
        IAllowUnsafeEval<StylesSrcDirectiveBuilder>,
        IAllowUnsafeHashes<StylesSrcDirectiveBuilder>,
        IAllowUnsafeInline<StylesSrcDirectiveBuilder>,
        IAllowNone<StylesSrcDirectiveBuilder>,
        IAllowNonce<StylesSrcDirectiveBuilder>,
        IAllowHash<StylesSrcDirectiveBuilder>
    {
        public new StylesSrcDirectiveBuilder AllowSelf() => (StylesSrcDirectiveBuilder)base.AllowSelf();
        public new StylesSrcDirectiveBuilder AllowUnsafeInline() => (StylesSrcDirectiveBuilder)base.AllowUnsafeInline();
        public new StylesSrcDirectiveBuilder AllowUnsafeInline(bool setThis) => (StylesSrcDirectiveBuilder)base.AllowUnsafeInline(setThis);
        public new StylesSrcDirectiveBuilder AllowUnsafeEval() => (StylesSrcDirectiveBuilder)base.AllowUnsafeEval();
        public new StylesSrcDirectiveBuilder AllowUnsafeEval(bool isDev) => (StylesSrcDirectiveBuilder)base.AllowUnsafeEval(isDev);
        public new StylesSrcDirectiveBuilder Allow(string source) => (StylesSrcDirectiveBuilder)base.Allow(source);
        public new StylesSrcDirectiveBuilder AllowNone() => (StylesSrcDirectiveBuilder)base.AllowNone();
        public new StylesSrcDirectiveBuilder AllowUnsafeHashes() => (StylesSrcDirectiveBuilder)base.AllowUnsafeHashes();
        public new StylesSrcDirectiveBuilder AllowUnsafeHashes(bool setThis) => (StylesSrcDirectiveBuilder)base.AllowUnsafeHashes(setThis);
        public new StylesSrcDirectiveBuilder AllowHash(HashDirective hash, string base64HashValue) => (StylesSrcDirectiveBuilder)base.AllowHash(hash, base64HashValue);
        public new StylesSrcDirectiveBuilder AllowNonce(string base64HashValue) => (StylesSrcDirectiveBuilder)base.AllowNonce(base64HashValue);
        public new StylesSrcDirectiveBuilder AllowSchemeSourceHttp() => (StylesSrcDirectiveBuilder)base.AllowSchemeSourceHttp();
        public new StylesSrcDirectiveBuilder AllowSchemeSourceHttps() => (StylesSrcDirectiveBuilder)base.AllowSchemeSourceHttps();
        public new StylesSrcDirectiveBuilder AllowAny() => (StylesSrcDirectiveBuilder)base.AllowAny();
        public new StylesSrcDirectiveBuilder AllowSchemeSourceData() => (StylesSrcDirectiveBuilder)base.AllowSchemeSourceData();
        public new StylesSrcDirectiveBuilder AllowSchemeSourceMediaStream() => (StylesSrcDirectiveBuilder)base.AllowSchemeSourceMediaStream();
        public new StylesSrcDirectiveBuilder AllowSchemeSourceBlob() => (StylesSrcDirectiveBuilder)base.AllowSchemeSourceBlob();
        public new StylesSrcDirectiveBuilder AllowSchemeSourceFilesystem() => (StylesSrcDirectiveBuilder)base.AllowSchemeSourceFilesystem();
    }
}
