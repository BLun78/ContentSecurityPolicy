using System.Runtime.InteropServices.ComTypes;

namespace Blun.ContentSecurityPolicy.Directives.Values
{
    public interface INone<T>
        where T : ContentSecurityPolicyOptionsDirectiveBuilder
    {
        T None();
    }
}