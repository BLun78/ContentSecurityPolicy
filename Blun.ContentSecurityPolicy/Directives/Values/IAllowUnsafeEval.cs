namespace Blun.ContentSecurityPolicy.Directives.Values
{
    public interface IAllowUnsafeEval<T>
    {
        T AllowUnsafeEval();
        T AllowUnsafeEval(bool setThis);
    }
}
