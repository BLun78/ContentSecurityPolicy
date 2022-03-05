using System;
using System.Collections.Generic;
using System.Text;
using Blun.ContentSecurityPolicy.Directives.Values;

namespace Blun.ContentSecurityPolicy.Directives
{
    public sealed class ConnectSrcDirectiveBuilder :
        ContentSecurityPolicyOptionsDirectiveBuilder,
        IAllow<ConnectSrcDirectiveBuilder>,
        IAllowSchemeSourceHttp<ConnectSrcDirectiveBuilder>,
        IAllowSchemeSourceHttps<ConnectSrcDirectiveBuilder>,
        IAllowSchemeSourceData<ConnectSrcDirectiveBuilder>,
        IAllowSchemeSourceMediaStream<ConnectSrcDirectiveBuilder>,
        IAllowSchemeSourceBlob<ConnectSrcDirectiveBuilder>,
        IAllowSchemeSourceFilesystem<ConnectSrcDirectiveBuilder>,
        IAllowAny<ConnectSrcDirectiveBuilder>,
        IAllowSelf<ConnectSrcDirectiveBuilder>,
        IAllowUnsafeEval<ConnectSrcDirectiveBuilder>,
        IAllowUnsafeHashes<ConnectSrcDirectiveBuilder>,
        IAllowUnsafeInline<ConnectSrcDirectiveBuilder>,
        INone<ConnectSrcDirectiveBuilder>,
        IAllowNonce<ConnectSrcDirectiveBuilder>,
        IAllowHash<ConnectSrcDirectiveBuilder>
    {
        public new ConnectSrcDirectiveBuilder AllowSelf() => (ConnectSrcDirectiveBuilder)base.AllowSelf();
        public new ConnectSrcDirectiveBuilder AllowUnsafeInline() => (ConnectSrcDirectiveBuilder)base.AllowUnsafeInline();
        public new ConnectSrcDirectiveBuilder AllowUnsafeInline(bool setThis) => (ConnectSrcDirectiveBuilder)base.AllowUnsafeInline(setThis);
        public new ConnectSrcDirectiveBuilder AllowUnsafeEval() => (ConnectSrcDirectiveBuilder)base.AllowUnsafeEval();
        public new ConnectSrcDirectiveBuilder AllowUnsafeEval(bool isDev) => (ConnectSrcDirectiveBuilder)base.AllowUnsafeEval(isDev);
        public new ConnectSrcDirectiveBuilder Allow(string source) => (ConnectSrcDirectiveBuilder)base.Allow(source);
        public new ConnectSrcDirectiveBuilder Allow(Uri source) => (ConnectSrcDirectiveBuilder)base.Allow(source);
        public new ConnectSrcDirectiveBuilder None() => (ConnectSrcDirectiveBuilder)base.AllowNone();
        public new ConnectSrcDirectiveBuilder AllowUnsafeHashes() => (ConnectSrcDirectiveBuilder)base.AllowUnsafeHashes();
        public new ConnectSrcDirectiveBuilder AllowUnsafeHashes(bool setThis) => (ConnectSrcDirectiveBuilder)base.AllowUnsafeHashes(setThis);
        public new ConnectSrcDirectiveBuilder AllowHash(HashDirective hash, string base64HashValue) => (ConnectSrcDirectiveBuilder)base.AllowHash(hash, base64HashValue);
        public new ConnectSrcDirectiveBuilder AllowNonce(string base64HashValue) => (ConnectSrcDirectiveBuilder)base.AllowNonce(base64HashValue);
        public new ConnectSrcDirectiveBuilder AllowSchemeSourceHttp() => (ConnectSrcDirectiveBuilder)base.AllowSchemeSourceHttp();
        public new ConnectSrcDirectiveBuilder AllowSchemeSourceHttps() => (ConnectSrcDirectiveBuilder)base.AllowSchemeSourceHttps();
        public new ConnectSrcDirectiveBuilder AllowAny() => (ConnectSrcDirectiveBuilder)base.AllowAny();
        public new ConnectSrcDirectiveBuilder AllowSchemeSourceData() => (ConnectSrcDirectiveBuilder)base.AllowSchemeSourceData();
        public new ConnectSrcDirectiveBuilder AllowSchemeSourceMediaStream() => (ConnectSrcDirectiveBuilder)base.AllowSchemeSourceMediaStream();
        public new ConnectSrcDirectiveBuilder AllowSchemeSourceBlob() => (ConnectSrcDirectiveBuilder)base.AllowSchemeSourceBlob();
        public new ConnectSrcDirectiveBuilder AllowSchemeSourceFilesystem() => (ConnectSrcDirectiveBuilder)base.AllowSchemeSourceFilesystem();
    }
}
