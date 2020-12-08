namespace Blun.ContentSecurityPolicy.Directives.Values
{
    public interface IAllowUnsafeHashes<T>
        where T : ContentSecurityPolicyOptionsDirectiveBuilder
    {
        T AllowUnsafeHashes();
        T AllowUnsafeHashes(bool setThis);
    }
}