namespace Blun.ContentSecurityPolicy.Directives.Values
{
    public interface IAllowUnsafeEval<T>
        where T : ContentSecurityPolicyOptionsDirectiveBuilder
    {
        T AllowUnsafeEval();
        T AllowUnsafeEval(bool setThis);
    }
}
