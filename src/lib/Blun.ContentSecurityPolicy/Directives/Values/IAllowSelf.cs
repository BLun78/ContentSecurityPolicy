namespace Blun.ContentSecurityPolicy.Directives.Values
{
    public interface IAllowSelf<T>
        where T : ContentSecurityPolicyOptionsDirectiveBuilder
    {
         T AllowSelf();
    }
}
