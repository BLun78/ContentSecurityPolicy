using System;
using System.Collections.Generic;
using System.Text;
using Blun.ContentSecurityPolicy.Directives.Values;

namespace Blun.ContentSecurityPolicy.Directives
{
    public sealed class ScriptsSrcDirectiveBuilder :
        ContentSecurityPolicyOptionsDirectiveBuilder,
        IAllow<ScriptsSrcDirectiveBuilder>,
        IAllowSchemeSourceHttp<ScriptsSrcDirectiveBuilder>,
        IAllowSchemeSourceHttps<ScriptsSrcDirectiveBuilder>,
        IAllowAny<ScriptsSrcDirectiveBuilder>,
        IAllowSelf<ScriptsSrcDirectiveBuilder>,
        IAllowUnsafeEval<ScriptsSrcDirectiveBuilder>,
        IAllowUnsafeHashes<ScriptsSrcDirectiveBuilder>,
        IAllowUnsafeInline<ScriptsSrcDirectiveBuilder>,
        IAllowNone<ScriptsSrcDirectiveBuilder>,
        IAllowNonce<ScriptsSrcDirectiveBuilder>,
        IAllowHash<ScriptsSrcDirectiveBuilder>,
        IAllowStrictDynamic<ScriptsSrcDirectiveBuilder>,
        IAllowReportSample<ScriptsSrcDirectiveBuilder>
    {
        public new ScriptsSrcDirectiveBuilder AllowSelf() => (ScriptsSrcDirectiveBuilder)base.AllowSelf();
        public new ScriptsSrcDirectiveBuilder AllowUnsafeInline() => (ScriptsSrcDirectiveBuilder)base.AllowUnsafeInline();
        public new ScriptsSrcDirectiveBuilder AllowUnsafeInline(bool setThis) => (ScriptsSrcDirectiveBuilder)base.AllowUnsafeInline(setThis);
        public new ScriptsSrcDirectiveBuilder AllowUnsafeEval() => (ScriptsSrcDirectiveBuilder)base.AllowUnsafeEval();
        public new ScriptsSrcDirectiveBuilder AllowUnsafeEval(bool isDev) => (ScriptsSrcDirectiveBuilder)base.AllowUnsafeEval(isDev);
        public new ScriptsSrcDirectiveBuilder Allow(string source) => (ScriptsSrcDirectiveBuilder)base.Allow(source);
        public new ScriptsSrcDirectiveBuilder AllowNone() => (ScriptsSrcDirectiveBuilder)base.AllowNone();
        public new ScriptsSrcDirectiveBuilder AllowUnsafeHashes() => (ScriptsSrcDirectiveBuilder)base.AllowUnsafeHashes();
        public new ScriptsSrcDirectiveBuilder AllowUnsafeHashes(bool setThis) => (ScriptsSrcDirectiveBuilder)base.AllowUnsafeHashes(setThis);
        public new ScriptsSrcDirectiveBuilder AllowStrictDynamic() => (ScriptsSrcDirectiveBuilder)base.AllowStrictDynamic();
        public new ScriptsSrcDirectiveBuilder AllowReportSample() => (ScriptsSrcDirectiveBuilder)base.AllowReportSample();
        public new ScriptsSrcDirectiveBuilder AllowHash(HashDirective hash, string base64HashValue) => (ScriptsSrcDirectiveBuilder)base.AllowHash(hash, base64HashValue);
        public new ScriptsSrcDirectiveBuilder AllowNonce(string base64HashValue) => (ScriptsSrcDirectiveBuilder)base.AllowNonce(base64HashValue);
        public new ScriptsSrcDirectiveBuilder AllowSchemeSourceHttp() => (ScriptsSrcDirectiveBuilder)base.AllowSchemeSourceHttp();
        public new ScriptsSrcDirectiveBuilder AllowSchemeSourceHttps() => (ScriptsSrcDirectiveBuilder)base.AllowSchemeSourceHttps();
        public new ScriptsSrcDirectiveBuilder AllowAny() => (ScriptsSrcDirectiveBuilder)base.AllowAny();
    }
}
