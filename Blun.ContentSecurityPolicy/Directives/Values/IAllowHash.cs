namespace Blun.ContentSecurityPolicy.Directives.Values
{
    public interface IAllowHash<T>
        where T : ContentSecurityPolicyOptionsDirectiveBuilder
    {
        T AllowHash(HashDirective hash, string base64HashValue);
    }
}