namespace Blun.ContentSecurityPolicy.Directives.Values
{
    public interface IAllowSchemeSourceHttps<T>
        where T : ContentSecurityPolicyOptionsDirectiveBuilder
    {
        T AllowSchemeSourceHttps();
    }
}