using System.Web;
using System.Web.Mvc;

namespace Blun.Csp.MvcWebapi.TestApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new global::Blun.ContentSecurityPolicy.Mvc.ContentSecurityPolicyActionFilterAttribute(builder =>
            {
                var isDevelopment = false;
#if DEBUG
                isDevelopment = true;
#endif

                builder.DefaultSrc
                    .AllowSelf()
                    .AllowUnsafeInline();

                builder.ScriptSrc
                    .AllowSelf()
                    .AllowUnsafeInline()
                    // ReSharper disable once ConditionIsAlwaysTrueOrFalse
                    .AllowUnsafeEval(isDevelopment);

                // ReSharper disable once ConditionIsAlwaysTrueOrFalse
                builder.ScriptSrc.AllowUnsafeEval(isDevelopment);

                builder.StyleSrc
                    .AllowSelf()
                    .AllowUnsafeInline();

                builder.FontSrc
                    .AllowSelf()
                    .AllowUnsafeInline()
                    .AllowSchemeSourceData();

                builder.ImgSrc
                    .AllowSelf()
                    .AllowUnsafeInline()
                    .AllowSchemeSourceData();

                builder.MediaSrc
                    .AllowSelf()
                    .AllowUnsafeInline();
            }));
        }
    }
}
