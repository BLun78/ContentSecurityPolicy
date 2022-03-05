
using System;
using Microsoft.AspNetCore.Builder;

namespace Blun.ContentSecurityPolicy.AspNetCore
{
    public static class ContentSecurityPolicyOptionsMiddlewareExtensions
    {
        public static IApplicationBuilder UseContentSecurityPolicy(
            this IApplicationBuilder app, Action<ContentSecurityPolicyOptionsBuilder> builder)
        {
            return UseCsp(app, builder);
        }

        public static IApplicationBuilder UseCsp(
            this IApplicationBuilder app, Action<ContentSecurityPolicyOptionsBuilder> builder)
        {
            var newBuilder = new ContentSecurityPolicyOptionsBuilder();
            builder(newBuilder);

            var options = newBuilder.Build();
            return app.UseMiddleware<ContentSecurityPolicyMiddleware>(options);
        }
    }
}