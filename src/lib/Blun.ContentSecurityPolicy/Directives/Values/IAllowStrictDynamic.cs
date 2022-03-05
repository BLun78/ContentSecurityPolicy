using System;
using System.Collections.Generic;
using System.Text;

namespace Blun.ContentSecurityPolicy.Directives.Values
{
    public interface IAllowStrictDynamic<T>
        where T : ContentSecurityPolicyOptionsDirectiveBuilder
    {
        T AllowStrictDynamic();
    }
}
