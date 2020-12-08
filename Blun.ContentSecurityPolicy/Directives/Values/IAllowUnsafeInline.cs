namespace Blun.ContentSecurityPolicy.Directives.Values
{
    public interface IAllowUnsafeInline<T>
        where T : ContentSecurityPolicyOptionsDirectiveBuilder
    {
        T AllowUnsafeInline();
        T AllowUnsafeInline(bool setThis);
    }
}