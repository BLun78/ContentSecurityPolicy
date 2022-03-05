using System;
using System.Collections.Generic;
using System.Text;
using Blun.ContentSecurityPolicy.Directives.Values;

namespace Blun.ContentSecurityPolicy.Directives
{
    public sealed class FontSrcDirectiveBuilder :
        ContentSecurityPolicyOptionsDirectiveBuilder,
        IAllow<FontSrcDirectiveBuilder>,
        IAllowSchemeSourceHttp<FontSrcDirectiveBuilder>,
        IAllowSchemeSourceHttps<FontSrcDirectiveBuilder>,
        IAllowSchemeSourceData<FontSrcDirectiveBuilder>,
        IAllowSchemeSourceMediaStream<FontSrcDirectiveBuilder>,
        IAllowSchemeSourceBlob<FontSrcDirectiveBuilder>,
        IAllowSchemeSourceFilesystem<FontSrcDirectiveBuilder>,
        IAllowAny<FontSrcDirectiveBuilder>,
        IAllowSelf<FontSrcDirectiveBuilder>,
        IAllowUnsafeEval<FontSrcDirectiveBuilder>,
        IAllowUnsafeHashes<FontSrcDirectiveBuilder>,
        IAllowUnsafeInline<FontSrcDirectiveBuilder>,
        INone<FontSrcDirectiveBuilder>,
        IAllowNonce<FontSrcDirectiveBuilder>,
        IAllowHash<FontSrcDirectiveBuilder>
    {
        public new FontSrcDirectiveBuilder AllowSelf() => (FontSrcDirectiveBuilder)base.AllowSelf();
        public new FontSrcDirectiveBuilder AllowUnsafeInline() => (FontSrcDirectiveBuilder)base.AllowUnsafeInline();
        public new FontSrcDirectiveBuilder AllowUnsafeInline(bool setThis) => (FontSrcDirectiveBuilder)base.AllowUnsafeInline(setThis);
        public new FontSrcDirectiveBuilder AllowUnsafeEval() => (FontSrcDirectiveBuilder)base.AllowUnsafeEval();
        public new FontSrcDirectiveBuilder AllowUnsafeEval(bool isDev) => (FontSrcDirectiveBuilder)base.AllowUnsafeEval(isDev);
        public new FontSrcDirectiveBuilder Allow(string source) => (FontSrcDirectiveBuilder)base.Allow(source);
        public new FontSrcDirectiveBuilder Allow(Uri source) => (FontSrcDirectiveBuilder)base.Allow(source);
        public new FontSrcDirectiveBuilder None() => (FontSrcDirectiveBuilder)base.AllowNone();
        public new FontSrcDirectiveBuilder AllowUnsafeHashes() => (FontSrcDirectiveBuilder)base.AllowUnsafeHashes();
        public new FontSrcDirectiveBuilder AllowUnsafeHashes(bool setThis) => (FontSrcDirectiveBuilder)base.AllowUnsafeHashes(setThis);
        public new FontSrcDirectiveBuilder AllowHash(HashDirective hash, string base64HashValue) => (FontSrcDirectiveBuilder)base.AllowHash(hash, base64HashValue);
        public new FontSrcDirectiveBuilder AllowNonce(string base64HashValue) => (FontSrcDirectiveBuilder)base.AllowNonce(base64HashValue);
        public new FontSrcDirectiveBuilder AllowSchemeSourceHttp() => (FontSrcDirectiveBuilder)base.AllowSchemeSourceHttp();
        public new FontSrcDirectiveBuilder AllowSchemeSourceHttps() => (FontSrcDirectiveBuilder)base.AllowSchemeSourceHttps();
        public new FontSrcDirectiveBuilder AllowAny() => (FontSrcDirectiveBuilder)base.AllowAny();
        public new FontSrcDirectiveBuilder AllowSchemeSourceData() => (FontSrcDirectiveBuilder)base.AllowSchemeSourceData();
        public new FontSrcDirectiveBuilder AllowSchemeSourceMediaStream() => (FontSrcDirectiveBuilder)base.AllowSchemeSourceMediaStream();
        public new FontSrcDirectiveBuilder AllowSchemeSourceBlob() => (FontSrcDirectiveBuilder)base.AllowSchemeSourceBlob();
        public new FontSrcDirectiveBuilder AllowSchemeSourceFilesystem() => (FontSrcDirectiveBuilder)base.AllowSchemeSourceFilesystem();
    }
}
