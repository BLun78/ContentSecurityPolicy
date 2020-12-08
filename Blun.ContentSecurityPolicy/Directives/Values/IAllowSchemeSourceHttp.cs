namespace Blun.ContentSecurityPolicy.Directives.Values
{
    public interface IAllowSchemeSourceHttp<T>
        where T : ContentSecurityPolicyOptionsDirectiveBuilder
    {
        T AllowSchemeSourceHttp();
    }
}