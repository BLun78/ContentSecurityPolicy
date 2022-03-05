namespace Blun.ContentSecurityPolicy.Directives.Values
{
    public interface IAllowSchemeSourceFilesystem<T>
        where T : ContentSecurityPolicyOptionsDirectiveBuilder
    {
        T AllowSchemeSourceFilesystem();
    }
}