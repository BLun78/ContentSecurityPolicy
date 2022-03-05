using System;
using System.Collections.Generic;
using System.Text;

namespace Blun.ContentSecurityPolicy.Directives.Values
{
    public interface IAllowReportSample<T>
        where T : ContentSecurityPolicyOptionsDirectiveBuilder
    {
        T AllowReportSample();
    }
}
