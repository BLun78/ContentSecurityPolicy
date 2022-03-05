using System;
using System.Collections.Generic;
using System.Text;

namespace Blun.ContentSecurityPolicy.Directives.Values
{
    public interface IAllowNonce<T>
        where T : ContentSecurityPolicyOptionsDirectiveBuilder
    {
        T AllowNonce(string base64HashValue);
    }
}
