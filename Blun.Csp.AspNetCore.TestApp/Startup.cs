using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blun.ContentSecurityPolicy.AspNetCore;

namespace Blun.Csp.AspNetCore.TestApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            // CSP = ContentSecurityPolicy
            app.UseContentSecurityPolicy(builder =>
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
                if (isDevelopment)
                {
                    builder.ScriptSrc.AllowUnsafeEval();
                }

                builder.StyleSrc
                    .AllowSelf()
                    .AllowUnsafeInline();

                builder.FontSrc
                    .AllowSelf()
                    .AllowUnsafeInline()
                    .AllowData();

                builder.ImgSrc
                    .AllowSelf()
                    .AllowUnsafeInline()
                    .AllowData();

                builder.MediaSrc
                    .AllowSelf()
                    .AllowUnsafeInline();
            });

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
