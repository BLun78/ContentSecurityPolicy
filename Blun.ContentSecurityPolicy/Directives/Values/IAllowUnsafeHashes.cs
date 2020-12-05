namespace Blun.ContentSecurityPolicy.Directives.Values
{
    public interface IAllowUnsafeHashes<T>
    {
        T AllowUnsafeHashes();
        T AllowUnsafeHashes(bool setThis);
    }
}