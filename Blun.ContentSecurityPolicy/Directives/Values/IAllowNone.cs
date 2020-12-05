using System.Runtime.InteropServices.ComTypes;

namespace Blun.ContentSecurityPolicy.Directives.Values
{
    public interface IAllowNone<T>
    {
        T AllowNone();
    }
}