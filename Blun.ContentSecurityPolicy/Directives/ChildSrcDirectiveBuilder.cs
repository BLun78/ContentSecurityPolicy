using System;
using System.Collections.Generic;
using System.Text;
using Blun.ContentSecurityPolicy.Directives.Values;

namespace Blun.ContentSecurityPolicy.Directives
{
    public sealed class ChildSrcDirectiveBuilder :
        ContentSecurityPolicyOptionsDirectiveBuilder,
        IAllow<ChildSrcDirectiveBuilder>,
        IAllowSchemeSourceHttp<ChildSrcDirectiveBuilder>,
        IAllowSchemeSourceHttps<ChildSrcDirectiveBuilder>,
        IAllowSchemeSourceData<ChildSrcDirectiveBuilder>,
        IAllowSchemeSourceMediaStream<ChildSrcDirectiveBuilder>,
        IAllowSchemeSourceBlob<ChildSrcDirectiveBuilder>,
        IAllowSchemeSourceFilesystem<ChildSrcDirectiveBuilder>,
        IAllowAny<ChildSrcDirectiveBuilder>,
        IAllowSelf<ChildSrcDirectiveBuilder>,
        IAllowUnsafeEval<ChildSrcDirectiveBuilder>,
        IAllowUnsafeHashes<ChildSrcDirectiveBuilder>,
        IAllowUnsafeInline<ChildSrcDirectiveBuilder>,
        IAllowNone<ChildSrcDirectiveBuilder>,
        IAllowNonce<ChildSrcDirectiveBuilder>,
        IAllowHash<ChildSrcDirectiveBuilder>,
        IAllowStrictDynamic<ChildSrcDirectiveBuilder>,
        IAllowReportSample<ChildSrcDirectiveBuilder>
    {
        public new ChildSrcDirectiveBuilder AllowSelf() => (ChildSrcDirectiveBuilder)base.AllowSelf();
        public new ChildSrcDirectiveBuilder AllowUnsafeInline() => (ChildSrcDirectiveBuilder)base.AllowUnsafeInline();
        public new ChildSrcDirectiveBuilder AllowUnsafeInline(bool setThis) => (ChildSrcDirectiveBuilder)base.AllowUnsafeInline(setThis);
        public new ChildSrcDirectiveBuilder AllowUnsafeEval() => (ChildSrcDirectiveBuilder)base.AllowUnsafeEval();
        public new ChildSrcDirectiveBuilder AllowUnsafeEval(bool isDev) => (ChildSrcDirectiveBuilder)base.AllowUnsafeEval(isDev);
        public new ChildSrcDirectiveBuilder Allow(string source) => (ChildSrcDirectiveBuilder)base.Allow(source);
        public new ChildSrcDirectiveBuilder AllowNone() => (ChildSrcDirectiveBuilder)base.AllowNone();
        public new ChildSrcDirectiveBuilder AllowUnsafeHashes() => (ChildSrcDirectiveBuilder)base.AllowUnsafeHashes();
        public new ChildSrcDirectiveBuilder AllowUnsafeHashes(bool setThis) => (ChildSrcDirectiveBuilder)base.AllowUnsafeHashes(setThis);
        public new ChildSrcDirectiveBuilder AllowStrictDynamic() => (ChildSrcDirectiveBuilder)base.AllowStrictDynamic();
        public new ChildSrcDirectiveBuilder AllowReportSample() => (ChildSrcDirectiveBuilder)base.AllowReportSample();
        public new ChildSrcDirectiveBuilder AllowHash(HashDirective hash, string base64HashValue) => (ChildSrcDirectiveBuilder)base.AllowHash(hash, base64HashValue);
        public new ChildSrcDirectiveBuilder AllowNonce(string base64HashValue) => (ChildSrcDirectiveBuilder)base.AllowNonce(base64HashValue);
        public new ChildSrcDirectiveBuilder AllowSchemeSourceHttp() => (ChildSrcDirectiveBuilder)base.AllowSchemeSourceHttp();
        public new ChildSrcDirectiveBuilder AllowSchemeSourceHttps() => (ChildSrcDirectiveBuilder)base.AllowSchemeSourceHttps();
        public new ChildSrcDirectiveBuilder AllowAny() => (ChildSrcDirectiveBuilder)base.AllowAny();
        public new ChildSrcDirectiveBuilder AllowSchemeSourceData() => (ChildSrcDirectiveBuilder)base.AllowSchemeSourceData();
        public new ChildSrcDirectiveBuilder AllowSchemeSourceMediaStream() => (ChildSrcDirectiveBuilder)base.AllowSchemeSourceMediaStream();
        public new ChildSrcDirectiveBuilder AllowSchemeSourceBlob() => (ChildSrcDirectiveBuilder)base.AllowSchemeSourceBlob();
        public new ChildSrcDirectiveBuilder AllowSchemeSourceFilesystem() => (ChildSrcDirectiveBuilder)base.AllowSchemeSourceFilesystem();
    }
}
