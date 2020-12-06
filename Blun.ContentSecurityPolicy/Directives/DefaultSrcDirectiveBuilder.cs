using System;
using System.Collections.Generic;
using System.Text;
using Blun.ContentSecurityPolicy.Directives.Values;

namespace Blun.ContentSecurityPolicy.Directives
{
    public sealed class DefaultSrcDirectiveBuilder :
        ContentSecurityPolicyOptionsDirectiveBuilder,
        IAllow<DefaultSrcDirectiveBuilder>,
        IAllowSchemeSourceHttp<DefaultSrcDirectiveBuilder>,
        IAllowSchemeSourceHttps<DefaultSrcDirectiveBuilder>,
        IAllowSchemeSourceData<DefaultSrcDirectiveBuilder>,
        IAllowSchemeSourceMediaStream<DefaultSrcDirectiveBuilder>,
        IAllowSchemeSourceBlob<DefaultSrcDirectiveBuilder>,
        IAllowSchemeSourceFilesystem<DefaultSrcDirectiveBuilder>,
        IAllowAny<DefaultSrcDirectiveBuilder>,
        IAllowSelf<DefaultSrcDirectiveBuilder>,
        IAllowUnsafeEval<DefaultSrcDirectiveBuilder>,
        IAllowUnsafeHashes<DefaultSrcDirectiveBuilder>,
        IAllowUnsafeInline<DefaultSrcDirectiveBuilder>,
        IAllowNone<DefaultSrcDirectiveBuilder>,
        IAllowNonce<DefaultSrcDirectiveBuilder>,
        IAllowHash<DefaultSrcDirectiveBuilder>,
        IAllowStrictDynamic<DefaultSrcDirectiveBuilder>,
        IAllowReportSample<DefaultSrcDirectiveBuilder>
    {
        public new DefaultSrcDirectiveBuilder AllowSelf() => (DefaultSrcDirectiveBuilder)base.AllowSelf();
        public new DefaultSrcDirectiveBuilder AllowUnsafeInline() => (DefaultSrcDirectiveBuilder)base.AllowUnsafeInline();
        public new DefaultSrcDirectiveBuilder AllowUnsafeInline(bool setThis) => (DefaultSrcDirectiveBuilder)base.AllowUnsafeInline(setThis);
        public new DefaultSrcDirectiveBuilder AllowUnsafeEval() => (DefaultSrcDirectiveBuilder)base.AllowUnsafeEval();
        public new DefaultSrcDirectiveBuilder AllowUnsafeEval(bool isDev) => (DefaultSrcDirectiveBuilder)base.AllowUnsafeEval(isDev);
        public new DefaultSrcDirectiveBuilder Allow(string source) => (DefaultSrcDirectiveBuilder)base.Allow(source);
        public new DefaultSrcDirectiveBuilder AllowNone() => (DefaultSrcDirectiveBuilder)base.AllowNone();
        public new DefaultSrcDirectiveBuilder AllowUnsafeHashes() => (DefaultSrcDirectiveBuilder)base.AllowUnsafeHashes();
        public new DefaultSrcDirectiveBuilder AllowUnsafeHashes(bool setThis) => (DefaultSrcDirectiveBuilder)base.AllowUnsafeHashes(setThis);
        public new DefaultSrcDirectiveBuilder AllowStrictDynamic() => (DefaultSrcDirectiveBuilder)base.AllowStrictDynamic();
        public new DefaultSrcDirectiveBuilder AllowReportSample() => (DefaultSrcDirectiveBuilder)base.AllowReportSample();
        public new DefaultSrcDirectiveBuilder AllowHash(HashDirective hash, string base64HashValue) => (DefaultSrcDirectiveBuilder)base.AllowHash(hash, base64HashValue);
        public new DefaultSrcDirectiveBuilder AllowNonce(string base64HashValue) => (DefaultSrcDirectiveBuilder)base.AllowNonce(base64HashValue);
        public new DefaultSrcDirectiveBuilder AllowSchemeSourceHttp() => (DefaultSrcDirectiveBuilder)base.AllowSchemeSourceHttp();
        public new DefaultSrcDirectiveBuilder AllowSchemeSourceHttps() => (DefaultSrcDirectiveBuilder)base.AllowSchemeSourceHttps();
        public new DefaultSrcDirectiveBuilder AllowAny() => (DefaultSrcDirectiveBuilder)base.AllowAny();
        public new DefaultSrcDirectiveBuilder AllowSchemeSourceData() => (DefaultSrcDirectiveBuilder)base.AllowSchemeSourceData();
        public new DefaultSrcDirectiveBuilder AllowSchemeSourceMediaStream() => (DefaultSrcDirectiveBuilder)base.AllowSchemeSourceMediaStream();
        public new DefaultSrcDirectiveBuilder AllowSchemeSourceBlob() => (DefaultSrcDirectiveBuilder)base.AllowSchemeSourceBlob();
        public new DefaultSrcDirectiveBuilder AllowSchemeSourceFilesystem() => (DefaultSrcDirectiveBuilder)base.AllowSchemeSourceFilesystem();
    }
}
