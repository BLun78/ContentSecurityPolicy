using System;
using System.Collections.Generic;
using System.Text;
using Blun.ContentSecurityPolicy.Directives.Values;

namespace Blun.ContentSecurityPolicy.Directives
{
    public class ScriptsSrcDirectiveBuilder1 :
        ContentSecurityPolicyOptionsDirectiveBuilder,
        IAllow<DefaultSrcDirectiveBuilder>,
        IAllowNone<DefaultSrcDirectiveBuilder>,
        IAllowSelf<DefaultSrcDirectiveBuilder>,
        IAllowUnsafeEval<DefaultSrcDirectiveBuilder>,
        IAllowUnsafeHashes<DefaultSrcDirectiveBuilder>,
        IAllowUnsafeInline<DefaultSrcDirectiveBuilder>,
        IAllowStrictDynamic<DefaultSrcDirectiveBuilder>,
        IAllowReportSample<DefaultSrcDirectiveBuilder>
    {
        public DefaultSrcDirectiveBuilder Allow(string source)
        {
            throw new NotImplementedException();
        }

        public DefaultSrcDirectiveBuilder AllowNone()
        {
            throw new NotImplementedException();
        }

        public DefaultSrcDirectiveBuilder AllowSelf()
        {
            throw new NotImplementedException();
        }

        public DefaultSrcDirectiveBuilder AllowUnsafeEval()
        {
            throw new NotImplementedException();
        }

        public DefaultSrcDirectiveBuilder AllowUnsafeEval(bool isDev)
        {
            throw new NotImplementedException();
        }

        public DefaultSrcDirectiveBuilder AllowUnsafeHashes()
        {
            throw new NotImplementedException();
        }

        public DefaultSrcDirectiveBuilder AllowUnsafeInline()
        {
            throw new NotImplementedException();
        }

        public DefaultSrcDirectiveBuilder AllowStrictDynamic()
        {
            throw new NotImplementedException();
        }

        public DefaultSrcDirectiveBuilder AllowReportSample()
        {
            throw new NotImplementedException();
        }
    }
}
