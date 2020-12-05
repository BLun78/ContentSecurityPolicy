namespace Blun.ContentSecurityPolicy.Directives.Values
{
    public interface IAllowHash<T>
    {
        T AllowHash(HashDirective hash, string base64HashValue);
    }
}