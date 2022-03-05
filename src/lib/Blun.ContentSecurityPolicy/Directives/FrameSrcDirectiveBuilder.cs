using System;
using System.Collections.Generic;
using System.Text;
using Blun.ContentSecurityPolicy.Directives.Values;

namespace Blun.ContentSecurityPolicy.Directives
{
    public sealed class FrameSrcDirectiveBuilder :
        ContentSecurityPolicyOptionsDirectiveBuilder,
        IAllow<FrameSrcDirectiveBuilder>,
        IAllowSchemeSourceHttp<FrameSrcDirectiveBuilder>,
        IAllowSchemeSourceHttps<FrameSrcDirectiveBuilder>,
        IAllowSchemeSourceData<FrameSrcDirectiveBuilder>,
        IAllowSchemeSourceMediaStream<FrameSrcDirectiveBuilder>,
        IAllowSchemeSourceBlob<FrameSrcDirectiveBuilder>,
        IAllowSchemeSourceFilesystem<FrameSrcDirectiveBuilder>,
        IAllowAny<FrameSrcDirectiveBuilder>,
        IAllowSelf<FrameSrcDirectiveBuilder>,
        IAllowUnsafeEval<FrameSrcDirectiveBuilder>,
        IAllowUnsafeHashes<FrameSrcDirectiveBuilder>,
        IAllowUnsafeInline<FrameSrcDirectiveBuilder>,
        INone<FrameSrcDirectiveBuilder>,
        IAllowNonce<FrameSrcDirectiveBuilder>,
        IAllowHash<FrameSrcDirectiveBuilder>
    {
        public new FrameSrcDirectiveBuilder AllowSelf() => (FrameSrcDirectiveBuilder)base.AllowSelf();
        public new FrameSrcDirectiveBuilder AllowUnsafeInline() => (FrameSrcDirectiveBuilder)base.AllowUnsafeInline();
        public new FrameSrcDirectiveBuilder AllowUnsafeInline(bool setThis) => (FrameSrcDirectiveBuilder)base.AllowUnsafeInline(setThis);
        public new FrameSrcDirectiveBuilder AllowUnsafeEval() => (FrameSrcDirectiveBuilder)base.AllowUnsafeEval();
        public new FrameSrcDirectiveBuilder AllowUnsafeEval(bool isDev) => (FrameSrcDirectiveBuilder)base.AllowUnsafeEval(isDev);
        public new FrameSrcDirectiveBuilder Allow(string source) => (FrameSrcDirectiveBuilder)base.Allow(source);
        public new FrameSrcDirectiveBuilder Allow(Uri source) => (FrameSrcDirectiveBuilder)base.Allow(source);
        public new FrameSrcDirectiveBuilder None() => (FrameSrcDirectiveBuilder)base.AllowNone();
        public new FrameSrcDirectiveBuilder AllowUnsafeHashes() => (FrameSrcDirectiveBuilder)base.AllowUnsafeHashes();
        public new FrameSrcDirectiveBuilder AllowUnsafeHashes(bool setThis) => (FrameSrcDirectiveBuilder)base.AllowUnsafeHashes(setThis);
        public new FrameSrcDirectiveBuilder AllowHash(HashDirective hash, string base64HashValue) => (FrameSrcDirectiveBuilder)base.AllowHash(hash, base64HashValue);
        public new FrameSrcDirectiveBuilder AllowNonce(string base64HashValue) => (FrameSrcDirectiveBuilder)base.AllowNonce(base64HashValue);
        public new FrameSrcDirectiveBuilder AllowSchemeSourceHttp() => (FrameSrcDirectiveBuilder)base.AllowSchemeSourceHttp();
        public new FrameSrcDirectiveBuilder AllowSchemeSourceHttps() => (FrameSrcDirectiveBuilder)base.AllowSchemeSourceHttps();
        public new FrameSrcDirectiveBuilder AllowAny() => (FrameSrcDirectiveBuilder)base.AllowAny();
        public new FrameSrcDirectiveBuilder AllowSchemeSourceData() => (FrameSrcDirectiveBuilder)base.AllowSchemeSourceData();
        public new FrameSrcDirectiveBuilder AllowSchemeSourceMediaStream() => (FrameSrcDirectiveBuilder)base.AllowSchemeSourceMediaStream();
        public new FrameSrcDirectiveBuilder AllowSchemeSourceBlob() => (FrameSrcDirectiveBuilder)base.AllowSchemeSourceBlob();
        public new FrameSrcDirectiveBuilder AllowSchemeSourceFilesystem() => (FrameSrcDirectiveBuilder)base.AllowSchemeSourceFilesystem();
    }
}
