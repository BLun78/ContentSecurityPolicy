using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Blun.ContentSecurityPolicy.Mvc
{
    public sealed class ContentSecurityPolicyActionFilterAttribute : ActionFilterAttribute,
        global::System.Web.Mvc.IActionFilter
    {
        private readonly HandleHeader _handleHeader;

        public ContentSecurityPolicyActionFilterAttribute(Action<ContentSecurityPolicyOptionsBuilder> builder)
        {
            var newBuilder = new ContentSecurityPolicyOptionsBuilder();
            builder(newBuilder);

            var contentSecurityPolicyOptions = newBuilder.Build();

            _handleHeader = new HandleHeader(contentSecurityPolicyOptions);
        }

        public new bool AllowMultiple => false;

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var headers = filterContext.HttpContext.Response.Headers;
            if (filterContext.HttpContext.Response.Headers.AllKeys.Any(x => x.Equals(_handleHeader.GetHeaderName)))
            {
                headers.Remove(_handleHeader.GetHeaderName);
            }
            if (!string.IsNullOrWhiteSpace(_handleHeader.GetHeaderValue()))
            {
                filterContext.HttpContext.Response.AppendHeader(_handleHeader.GetHeaderName, _handleHeader.GetHeaderValue());
            }
        }

    }
}
