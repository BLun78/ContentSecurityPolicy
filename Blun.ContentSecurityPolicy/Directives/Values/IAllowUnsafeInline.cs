namespace Blun.ContentSecurityPolicy.Directives.Values
{
    public interface IAllowUnsafeInline<T>
    {
        T AllowUnsafeInline();
        T AllowUnsafeInline(bool setThis);
    }
}