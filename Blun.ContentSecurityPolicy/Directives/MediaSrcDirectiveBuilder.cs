using System;
using System.Collections.Generic;
using System.Text;
using Blun.ContentSecurityPolicy.Directives.Values;

namespace Blun.ContentSecurityPolicy.Directives
{
    public sealed class MediaSrcDirectiveBuilder :
        ContentSecurityPolicyOptionsDirectiveBuilder,
        IAllow<MediaSrcDirectiveBuilder>,
        IAllowSchemeSourceHttp<MediaSrcDirectiveBuilder>,
        IAllowSchemeSourceHttps<MediaSrcDirectiveBuilder>,
        IAllowAny<MediaSrcDirectiveBuilder>,
        IAllowSelf<MediaSrcDirectiveBuilder>,
        IAllowUnsafeEval<MediaSrcDirectiveBuilder>,
        IAllowUnsafeHashes<MediaSrcDirectiveBuilder>,
        IAllowUnsafeInline<MediaSrcDirectiveBuilder>,
        IAllowNone<MediaSrcDirectiveBuilder>,
        IAllowNonce<MediaSrcDirectiveBuilder>,
        IAllowHash<MediaSrcDirectiveBuilder>,
        IAllowStrictDynamic<MediaSrcDirectiveBuilder>,
        IAllowReportSample<MediaSrcDirectiveBuilder>
    {
        public new MediaSrcDirectiveBuilder AllowSelf() => (MediaSrcDirectiveBuilder)base.AllowSelf();
        public new MediaSrcDirectiveBuilder AllowUnsafeInline() => (MediaSrcDirectiveBuilder)base.AllowUnsafeInline();
        public new MediaSrcDirectiveBuilder AllowUnsafeInline(bool setThis) => (MediaSrcDirectiveBuilder)base.AllowUnsafeInline(setThis);
        public new MediaSrcDirectiveBuilder AllowUnsafeEval() => (MediaSrcDirectiveBuilder)base.AllowUnsafeEval();
        public new MediaSrcDirectiveBuilder AllowUnsafeEval(bool isDev) => (MediaSrcDirectiveBuilder)base.AllowUnsafeEval(isDev);
        public new MediaSrcDirectiveBuilder Allow(string source) => (MediaSrcDirectiveBuilder)base.Allow(source);
        public new MediaSrcDirectiveBuilder AllowNone() => (MediaSrcDirectiveBuilder)base.AllowNone();
        public new MediaSrcDirectiveBuilder AllowUnsafeHashes() => (MediaSrcDirectiveBuilder)base.AllowUnsafeHashes();
        public new MediaSrcDirectiveBuilder AllowUnsafeHashes(bool setThis) => (MediaSrcDirectiveBuilder)base.AllowUnsafeHashes(setThis);
        public new MediaSrcDirectiveBuilder AllowStrictDynamic() => (MediaSrcDirectiveBuilder)base.AllowStrictDynamic();
        public new MediaSrcDirectiveBuilder AllowReportSample() => (MediaSrcDirectiveBuilder)base.AllowReportSample();
        public new MediaSrcDirectiveBuilder AllowHash(HashDirective hash, string base64HashValue) => (MediaSrcDirectiveBuilder)base.AllowHash(hash, base64HashValue);
        public new MediaSrcDirectiveBuilder AllowNonce(string base64HashValue) => (MediaSrcDirectiveBuilder)base.AllowNonce(base64HashValue);
        public new MediaSrcDirectiveBuilder AllowSchemeSourceHttp() => (MediaSrcDirectiveBuilder)base.AllowSchemeSourceHttp();
        public new MediaSrcDirectiveBuilder AllowSchemeSourceHttps() => (MediaSrcDirectiveBuilder)base.AllowSchemeSourceHttps();
        public new MediaSrcDirectiveBuilder AllowAny() => (MediaSrcDirectiveBuilder)base.AllowAny();
    }
}
