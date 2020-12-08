namespace Blun.ContentSecurityPolicy.Directives.Values
{
    public interface IAllowAny<T>
        where T : ContentSecurityPolicyOptionsDirectiveBuilder
    {
        T AllowAny();
    }
}