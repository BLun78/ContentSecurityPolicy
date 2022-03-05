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
        IAllowSchemeSourceData<MediaSrcDirectiveBuilder>,
        IAllowSchemeSourceMediaStream<MediaSrcDirectiveBuilder>,
        IAllowSchemeSourceBlob<MediaSrcDirectiveBuilder>,
        IAllowSchemeSourceFilesystem<MediaSrcDirectiveBuilder>,
        IAllowAny<MediaSrcDirectiveBuilder>,
        IAllowSelf<MediaSrcDirectiveBuilder>,
        IAllowUnsafeEval<MediaSrcDirectiveBuilder>,
        IAllowUnsafeHashes<MediaSrcDirectiveBuilder>,
        IAllowUnsafeInline<MediaSrcDirectiveBuilder>,
        INone<MediaSrcDirectiveBuilder>,
        IAllowNonce<MediaSrcDirectiveBuilder>,
        IAllowHash<MediaSrcDirectiveBuilder>
    {
        public new MediaSrcDirectiveBuilder AllowSelf() => (MediaSrcDirectiveBuilder)base.AllowSelf();
        public new MediaSrcDirectiveBuilder AllowUnsafeInline() => (MediaSrcDirectiveBuilder)base.AllowUnsafeInline();
        public new MediaSrcDirectiveBuilder AllowUnsafeInline(bool setThis) => (MediaSrcDirectiveBuilder)base.AllowUnsafeInline(setThis);
        public new MediaSrcDirectiveBuilder AllowUnsafeEval() => (MediaSrcDirectiveBuilder)base.AllowUnsafeEval();
        public new MediaSrcDirectiveBuilder AllowUnsafeEval(bool isDev) => (MediaSrcDirectiveBuilder)base.AllowUnsafeEval(isDev);
        public new MediaSrcDirectiveBuilder Allow(string source) => (MediaSrcDirectiveBuilder)base.Allow(source);
        public new MediaSrcDirectiveBuilder Allow(Uri source) => (MediaSrcDirectiveBuilder)base.Allow(source);
        public new MediaSrcDirectiveBuilder None() => (MediaSrcDirectiveBuilder)base.AllowNone();
        public new MediaSrcDirectiveBuilder AllowUnsafeHashes() => (MediaSrcDirectiveBuilder)base.AllowUnsafeHashes();
        public new MediaSrcDirectiveBuilder AllowUnsafeHashes(bool setThis) => (MediaSrcDirectiveBuilder)base.AllowUnsafeHashes(setThis);
        public new MediaSrcDirectiveBuilder AllowHash(HashDirective hash, string base64HashValue) => (MediaSrcDirectiveBuilder)base.AllowHash(hash, base64HashValue);
        public new MediaSrcDirectiveBuilder AllowNonce(string base64HashValue) => (MediaSrcDirectiveBuilder)base.AllowNonce(base64HashValue);
        public new MediaSrcDirectiveBuilder AllowSchemeSourceHttp() => (MediaSrcDirectiveBuilder)base.AllowSchemeSourceHttp();
        public new MediaSrcDirectiveBuilder AllowSchemeSourceHttps() => (MediaSrcDirectiveBuilder)base.AllowSchemeSourceHttps();
        public new MediaSrcDirectiveBuilder AllowAny() => (MediaSrcDirectiveBuilder)base.AllowAny(); 
        public new MediaSrcDirectiveBuilder AllowSchemeSourceData() => (MediaSrcDirectiveBuilder)base.AllowSchemeSourceData();
        public new MediaSrcDirectiveBuilder AllowSchemeSourceMediaStream() => (MediaSrcDirectiveBuilder)base.AllowSchemeSourceMediaStream();
        public new MediaSrcDirectiveBuilder AllowSchemeSourceBlob() => (MediaSrcDirectiveBuilder)base.AllowSchemeSourceBlob();
        public new MediaSrcDirectiveBuilder AllowSchemeSourceFilesystem() => (MediaSrcDirectiveBuilder)base.AllowSchemeSourceFilesystem();

    }
}
