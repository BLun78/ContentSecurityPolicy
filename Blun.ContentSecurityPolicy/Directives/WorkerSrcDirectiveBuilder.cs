using System;
using System.Collections.Generic;
using System.Text;
using Blun.ContentSecurityPolicy.Directives.Values;

namespace Blun.ContentSecurityPolicy.Directives
{
    public sealed class WorkerSrcDirectiveBuilder :
        ContentSecurityPolicyOptionsDirectiveBuilder,
        IAllow<WorkerSrcDirectiveBuilder>,
        IAllowSchemeSourceHttp<WorkerSrcDirectiveBuilder>,
        IAllowSchemeSourceHttps<WorkerSrcDirectiveBuilder>,
        IAllowSchemeSourceData<WorkerSrcDirectiveBuilder>,
        IAllowSchemeSourceMediaStream<WorkerSrcDirectiveBuilder>,
        IAllowSchemeSourceBlob<WorkerSrcDirectiveBuilder>,
        IAllowSchemeSourceFilesystem<WorkerSrcDirectiveBuilder>,
        IAllowAny<WorkerSrcDirectiveBuilder>,
        IAllowSelf<WorkerSrcDirectiveBuilder>,
        IAllowUnsafeEval<WorkerSrcDirectiveBuilder>,
        IAllowUnsafeHashes<WorkerSrcDirectiveBuilder>,
        IAllowUnsafeInline<WorkerSrcDirectiveBuilder>,
        IAllowNone<WorkerSrcDirectiveBuilder>,
        IAllowNonce<WorkerSrcDirectiveBuilder>,
        IAllowHash<WorkerSrcDirectiveBuilder>
    {
        public new WorkerSrcDirectiveBuilder AllowSelf() => (WorkerSrcDirectiveBuilder)base.AllowSelf();
        public new WorkerSrcDirectiveBuilder AllowUnsafeInline() => (WorkerSrcDirectiveBuilder)base.AllowUnsafeInline();
        public new WorkerSrcDirectiveBuilder AllowUnsafeInline(bool setThis) => (WorkerSrcDirectiveBuilder)base.AllowUnsafeInline(setThis);
        public new WorkerSrcDirectiveBuilder AllowUnsafeEval() => (WorkerSrcDirectiveBuilder)base.AllowUnsafeEval();
        public new WorkerSrcDirectiveBuilder AllowUnsafeEval(bool isDev) => (WorkerSrcDirectiveBuilder)base.AllowUnsafeEval(isDev);
        public new WorkerSrcDirectiveBuilder Allow(string source) => (WorkerSrcDirectiveBuilder)base.Allow(source);
        public new WorkerSrcDirectiveBuilder Allow(Uri source) => (WorkerSrcDirectiveBuilder)base.Allow(source);
        public new WorkerSrcDirectiveBuilder AllowNone() => (WorkerSrcDirectiveBuilder)base.AllowNone();
        public new WorkerSrcDirectiveBuilder AllowUnsafeHashes() => (WorkerSrcDirectiveBuilder)base.AllowUnsafeHashes();
        public new WorkerSrcDirectiveBuilder AllowUnsafeHashes(bool setThis) => (WorkerSrcDirectiveBuilder)base.AllowUnsafeHashes(setThis);
        public new WorkerSrcDirectiveBuilder AllowHash(HashDirective hash, string base64HashValue) => (WorkerSrcDirectiveBuilder)base.AllowHash(hash, base64HashValue);
        public new WorkerSrcDirectiveBuilder AllowNonce(string base64HashValue) => (WorkerSrcDirectiveBuilder)base.AllowNonce(base64HashValue);
        public new WorkerSrcDirectiveBuilder AllowSchemeSourceHttp() => (WorkerSrcDirectiveBuilder)base.AllowSchemeSourceHttp();
        public new WorkerSrcDirectiveBuilder AllowSchemeSourceHttps() => (WorkerSrcDirectiveBuilder)base.AllowSchemeSourceHttps();
        public new WorkerSrcDirectiveBuilder AllowAny() => (WorkerSrcDirectiveBuilder)base.AllowAny();
        public new WorkerSrcDirectiveBuilder AllowSchemeSourceData() => (WorkerSrcDirectiveBuilder)base.AllowSchemeSourceData();
        public new WorkerSrcDirectiveBuilder AllowSchemeSourceMediaStream() => (WorkerSrcDirectiveBuilder)base.AllowSchemeSourceMediaStream();
        public new WorkerSrcDirectiveBuilder AllowSchemeSourceBlob() => (WorkerSrcDirectiveBuilder)base.AllowSchemeSourceBlob();
        public new WorkerSrcDirectiveBuilder AllowSchemeSourceFilesystem() => (WorkerSrcDirectiveBuilder)base.AllowSchemeSourceFilesystem();
    }
}
