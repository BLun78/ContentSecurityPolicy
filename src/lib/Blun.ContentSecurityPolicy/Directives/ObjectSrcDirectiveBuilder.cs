using System;
using System.Collections.Generic;
using System.Text;
using Blun.ContentSecurityPolicy.Directives.Values;

namespace Blun.ContentSecurityPolicy.Directives
{
    public sealed class ObjectSrcDirectiveBuilder :
        ContentSecurityPolicyOptionsDirectiveBuilder,
        IAllow<ObjectSrcDirectiveBuilder>,
        IAllowSchemeSourceHttp<ObjectSrcDirectiveBuilder>,
        IAllowSchemeSourceHttps<ObjectSrcDirectiveBuilder>,
        IAllowSchemeSourceData<ObjectSrcDirectiveBuilder>,
        IAllowSchemeSourceMediaStream<ObjectSrcDirectiveBuilder>,
        IAllowSchemeSourceBlob<ObjectSrcDirectiveBuilder>,
        IAllowSchemeSourceFilesystem<ObjectSrcDirectiveBuilder>,
        IAllowAny<ObjectSrcDirectiveBuilder>,
        IAllowSelf<ObjectSrcDirectiveBuilder>,
        IAllowUnsafeEval<ObjectSrcDirectiveBuilder>,
        IAllowUnsafeHashes<ObjectSrcDirectiveBuilder>,
        IAllowUnsafeInline<ObjectSrcDirectiveBuilder>,
        INone<ObjectSrcDirectiveBuilder>,
        IAllowNonce<ObjectSrcDirectiveBuilder>,
        IAllowHash<ObjectSrcDirectiveBuilder>
    {
        public new ObjectSrcDirectiveBuilder AllowSelf() => (ObjectSrcDirectiveBuilder)base.AllowSelf();
        public new ObjectSrcDirectiveBuilder AllowUnsafeInline() => (ObjectSrcDirectiveBuilder)base.AllowUnsafeInline();
        public new ObjectSrcDirectiveBuilder AllowUnsafeInline(bool setThis) => (ObjectSrcDirectiveBuilder)base.AllowUnsafeInline(setThis);
        public new ObjectSrcDirectiveBuilder AllowUnsafeEval() => (ObjectSrcDirectiveBuilder)base.AllowUnsafeEval();
        public new ObjectSrcDirectiveBuilder AllowUnsafeEval(bool isDev) => (ObjectSrcDirectiveBuilder)base.AllowUnsafeEval(isDev);
        public new ObjectSrcDirectiveBuilder Allow(string source) => (ObjectSrcDirectiveBuilder)base.Allow(source);
        public new ObjectSrcDirectiveBuilder Allow(Uri source) => (ObjectSrcDirectiveBuilder)base.Allow(source);
        public new ObjectSrcDirectiveBuilder None() => (ObjectSrcDirectiveBuilder)base.AllowNone();
        public new ObjectSrcDirectiveBuilder AllowUnsafeHashes() => (ObjectSrcDirectiveBuilder)base.AllowUnsafeHashes();
        public new ObjectSrcDirectiveBuilder AllowUnsafeHashes(bool setThis) => (ObjectSrcDirectiveBuilder)base.AllowUnsafeHashes(setThis);
        public new ObjectSrcDirectiveBuilder AllowHash(HashDirective hash, string base64HashValue) => (ObjectSrcDirectiveBuilder)base.AllowHash(hash, base64HashValue);
        public new ObjectSrcDirectiveBuilder AllowNonce(string base64HashValue) => (ObjectSrcDirectiveBuilder)base.AllowNonce(base64HashValue);
        public new ObjectSrcDirectiveBuilder AllowSchemeSourceHttp() => (ObjectSrcDirectiveBuilder)base.AllowSchemeSourceHttp();
        public new ObjectSrcDirectiveBuilder AllowSchemeSourceHttps() => (ObjectSrcDirectiveBuilder)base.AllowSchemeSourceHttps();
        public new ObjectSrcDirectiveBuilder AllowAny() => (ObjectSrcDirectiveBuilder)base.AllowAny();
        public new ObjectSrcDirectiveBuilder AllowSchemeSourceData() => (ObjectSrcDirectiveBuilder)base.AllowSchemeSourceData();
        public new ObjectSrcDirectiveBuilder AllowSchemeSourceMediaStream() => (ObjectSrcDirectiveBuilder)base.AllowSchemeSourceMediaStream();
        public new ObjectSrcDirectiveBuilder AllowSchemeSourceBlob() => (ObjectSrcDirectiveBuilder)base.AllowSchemeSourceBlob();
        public new ObjectSrcDirectiveBuilder AllowSchemeSourceFilesystem() => (ObjectSrcDirectiveBuilder)base.AllowSchemeSourceFilesystem();
    }
}
