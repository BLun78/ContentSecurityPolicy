using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Blun.Csp.MvcWebapi.TestApp
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.Filters.Add(new global::Blun.ContentSecurityPolicy.Webapi.ContentSecurityPolicyActionFilterAttribute(builder =>
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

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
