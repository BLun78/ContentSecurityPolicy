using System;
using System.Collections.Generic;
using System.Text;

namespace Blun.ContentSecurityPolicy.Directives.Values
{
    public interface IReportingUri<T>
        where T: class
    {
        T SetReportingUri(string uri);
        T SetReportingUri(Uri uri);
    }
}
