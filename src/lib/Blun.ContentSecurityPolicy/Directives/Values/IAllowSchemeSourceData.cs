namespace Blun.ContentSecurityPolicy.Directives.Values
{
    public interface IAllowSchemeSourceData<T>
        where T : ContentSecurityPolicyOptionsDirectiveBuilder
    {
        T AllowSchemeSourceData();
    }
}