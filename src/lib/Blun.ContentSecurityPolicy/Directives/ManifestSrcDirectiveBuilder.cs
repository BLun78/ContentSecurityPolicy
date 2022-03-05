using System;
using System.Collections.Generic;
using System.Text;
using Blun.ContentSecurityPolicy.Directives.Values;

namespace Blun.ContentSecurityPolicy.Directives
{
    public sealed class ManifestSrcDirectiveBuilder :
        ContentSecurityPolicyOptionsDirectiveBuilder,
        IAllow<ManifestSrcDirectiveBuilder>,
        IAllowSchemeSourceHttp<ManifestSrcDirectiveBuilder>,
        IAllowSchemeSourceHttps<ManifestSrcDirectiveBuilder>,
        IAllowSchemeSourceData<ManifestSrcDirectiveBuilder>,
        IAllowSchemeSourceMediaStream<ManifestSrcDirectiveBuilder>,
        IAllowSchemeSourceBlob<ManifestSrcDirectiveBuilder>,
        IAllowSchemeSourceFilesystem<ManifestSrcDirectiveBuilder>,
        IAllowAny<ManifestSrcDirectiveBuilder>,
        IAllowSelf<ManifestSrcDirectiveBuilder>,
        IAllowUnsafeEval<ManifestSrcDirectiveBuilder>,
        IAllowUnsafeHashes<ManifestSrcDirectiveBuilder>,
        IAllowUnsafeInline<ManifestSrcDirectiveBuilder>,
        INone<ManifestSrcDirectiveBuilder>,
        IAllowNonce<ManifestSrcDirectiveBuilder>,
        IAllowHash<ManifestSrcDirectiveBuilder>
    {
        public new ManifestSrcDirectiveBuilder AllowSelf() => (ManifestSrcDirectiveBuilder)base.AllowSelf();
        public new ManifestSrcDirectiveBuilder AllowUnsafeInline() => (ManifestSrcDirectiveBuilder)base.AllowUnsafeInline();
        public new ManifestSrcDirectiveBuilder AllowUnsafeInline(bool setThis) => (ManifestSrcDirectiveBuilder)base.AllowUnsafeInline(setThis);
        public new ManifestSrcDirectiveBuilder AllowUnsafeEval() => (ManifestSrcDirectiveBuilder)base.AllowUnsafeEval();
        public new ManifestSrcDirectiveBuilder AllowUnsafeEval(bool isDev) => (ManifestSrcDirectiveBuilder)base.AllowUnsafeEval(isDev);
        public new ManifestSrcDirectiveBuilder Allow(string source) => (ManifestSrcDirectiveBuilder)base.Allow(source);
        public new ManifestSrcDirectiveBuilder None() => (ManifestSrcDirectiveBuilder)base.AllowNone();
        public new ManifestSrcDirectiveBuilder Allow(Uri source) => (ManifestSrcDirectiveBuilder)base.Allow(source);
        public new ManifestSrcDirectiveBuilder AllowUnsafeHashes() => (ManifestSrcDirectiveBuilder)base.AllowUnsafeHashes();
        public new ManifestSrcDirectiveBuilder AllowUnsafeHashes(bool setThis) => (ManifestSrcDirectiveBuilder)base.AllowUnsafeHashes(setThis);
        public new ManifestSrcDirectiveBuilder AllowHash(HashDirective hash, string base64HashValue) => (ManifestSrcDirectiveBuilder)base.AllowHash(hash, base64HashValue);
        public new ManifestSrcDirectiveBuilder AllowNonce(string base64HashValue) => (ManifestSrcDirectiveBuilder)base.AllowNonce(base64HashValue);
        public new ManifestSrcDirectiveBuilder AllowSchemeSourceHttp() => (ManifestSrcDirectiveBuilder)base.AllowSchemeSourceHttp();
        public new ManifestSrcDirectiveBuilder AllowSchemeSourceHttps() => (ManifestSrcDirectiveBuilder)base.AllowSchemeSourceHttps();
        public new ManifestSrcDirectiveBuilder AllowAny() => (ManifestSrcDirectiveBuilder)base.AllowAny();
        public new ManifestSrcDirectiveBuilder AllowSchemeSourceData() => (ManifestSrcDirectiveBuilder)base.AllowSchemeSourceData();
        public new ManifestSrcDirectiveBuilder AllowSchemeSourceMediaStream() => (ManifestSrcDirectiveBuilder)base.AllowSchemeSourceMediaStream();
        public new ManifestSrcDirectiveBuilder AllowSchemeSourceBlob() => (ManifestSrcDirectiveBuilder)base.AllowSchemeSourceBlob();
        public new ManifestSrcDirectiveBuilder AllowSchemeSourceFilesystem() => (ManifestSrcDirectiveBuilder)base.AllowSchemeSourceFilesystem();
    }
}
