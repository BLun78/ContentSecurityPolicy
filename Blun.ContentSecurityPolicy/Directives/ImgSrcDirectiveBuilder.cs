using System;
using System.Collections.Generic;
using System.Text;
using Blun.ContentSecurityPolicy.Directives.Values;

namespace Blun.ContentSecurityPolicy.Directives
{
    public sealed class ImgSrcDirectiveBuilder :
        ContentSecurityPolicyOptionsDirectiveBuilder,
        IAllow<ImgSrcDirectiveBuilder>,
        IAllowSchemeSourceHttp<ImgSrcDirectiveBuilder>,
        IAllowSchemeSourceHttps<ImgSrcDirectiveBuilder>,
        IAllowSchemeSourceData<ImgSrcDirectiveBuilder>,
        IAllowSchemeSourceMediaStream<ImgSrcDirectiveBuilder>,
        IAllowSchemeSourceBlob<ImgSrcDirectiveBuilder>,
        IAllowSchemeSourceFilesystem<ImgSrcDirectiveBuilder>,
        IAllowAny<ImgSrcDirectiveBuilder>,
        IAllowSelf<ImgSrcDirectiveBuilder>,
        IAllowUnsafeEval<ImgSrcDirectiveBuilder>,
        IAllowUnsafeHashes<ImgSrcDirectiveBuilder>,
        IAllowUnsafeInline<ImgSrcDirectiveBuilder>,
        IAllowNone<ImgSrcDirectiveBuilder>,
        IAllowNonce<ImgSrcDirectiveBuilder>,
        IAllowHash<ImgSrcDirectiveBuilder>,
        IAllowStrictDynamic<ImgSrcDirectiveBuilder>,
        IAllowReportSample<ImgSrcDirectiveBuilder>
    {
        public new ImgSrcDirectiveBuilder AllowSelf() => (ImgSrcDirectiveBuilder)base.AllowSelf();
        public new ImgSrcDirectiveBuilder AllowUnsafeInline() => (ImgSrcDirectiveBuilder)base.AllowUnsafeInline();
        public new ImgSrcDirectiveBuilder AllowUnsafeInline(bool setThis) => (ImgSrcDirectiveBuilder)base.AllowUnsafeInline(setThis);
        public new ImgSrcDirectiveBuilder AllowUnsafeEval() => (ImgSrcDirectiveBuilder)base.AllowUnsafeEval();
        public new ImgSrcDirectiveBuilder AllowUnsafeEval(bool isDev) => (ImgSrcDirectiveBuilder)base.AllowUnsafeEval(isDev);
        public new ImgSrcDirectiveBuilder Allow(string source) => (ImgSrcDirectiveBuilder)base.Allow(source);
        public new ImgSrcDirectiveBuilder AllowNone() => (ImgSrcDirectiveBuilder)base.AllowNone();
        public new ImgSrcDirectiveBuilder AllowUnsafeHashes() => (ImgSrcDirectiveBuilder)base.AllowUnsafeHashes();
        public new ImgSrcDirectiveBuilder AllowUnsafeHashes(bool setThis) => (ImgSrcDirectiveBuilder)base.AllowUnsafeHashes(setThis);
        public new ImgSrcDirectiveBuilder AllowStrictDynamic() => (ImgSrcDirectiveBuilder)base.AllowStrictDynamic();
        public new ImgSrcDirectiveBuilder AllowReportSample() => (ImgSrcDirectiveBuilder)base.AllowReportSample();
        public new ImgSrcDirectiveBuilder AllowHash(HashDirective hash, string base64HashValue) => (ImgSrcDirectiveBuilder)base.AllowHash(hash, base64HashValue);
        public new ImgSrcDirectiveBuilder AllowNonce(string base64HashValue) => (ImgSrcDirectiveBuilder)base.AllowNonce(base64HashValue);
        public new ImgSrcDirectiveBuilder AllowSchemeSourceHttp() => (ImgSrcDirectiveBuilder)base.AllowSchemeSourceHttp();
        public new ImgSrcDirectiveBuilder AllowSchemeSourceHttps() => (ImgSrcDirectiveBuilder)base.AllowSchemeSourceHttps();
        public new ImgSrcDirectiveBuilder AllowAny() => (ImgSrcDirectiveBuilder)base.AllowAny(); 
        public new ImgSrcDirectiveBuilder AllowSchemeSourceData() => (ImgSrcDirectiveBuilder)base.AllowSchemeSourceData();
        public new ImgSrcDirectiveBuilder AllowSchemeSourceMediaStream() => (ImgSrcDirectiveBuilder)base.AllowSchemeSourceMediaStream();
        public new ImgSrcDirectiveBuilder AllowSchemeSourceBlob() => (ImgSrcDirectiveBuilder)base.AllowSchemeSourceBlob();
        public new ImgSrcDirectiveBuilder AllowSchemeSourceFilesystem() => (ImgSrcDirectiveBuilder)base.AllowSchemeSourceFilesystem();

    }
}
