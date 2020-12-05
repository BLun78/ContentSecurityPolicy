namespace Blun.ContentSecurityPolicy.Directives.Values
{
    public interface IAllow<T>
    {
        T Allow(string source);
    }
}