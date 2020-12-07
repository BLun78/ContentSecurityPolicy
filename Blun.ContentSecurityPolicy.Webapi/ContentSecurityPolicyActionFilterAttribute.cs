using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace Blun.ContentSecurityPolicy.Webapi
{
    public class ContentSecurityPolicyActionFilterAttribute : ActionFilterAttribute,
        global::System.Web.Http.Filters.IActionFilter
    {
        private readonly HandleHeader _handleHeader;

        public ContentSecurityPolicyActionFilterAttribute(Action<ContentSecurityPolicyOptionsBuilder> builder)
        {
            var newBuilder = new ContentSecurityPolicyOptionsBuilder();
            builder(newBuilder);

            var contentSecurityPolicyOptions = newBuilder.Build();

            _handleHeader = new HandleHeader(contentSecurityPolicyOptions);
        }

        public override bool AllowMultiple => false;

        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            var headers = actionContext.Response.Headers;
            if (actionContext.Response.Headers.Contains(_handleHeader.GetHeaderName))
            {
                headers.Remove(_handleHeader.GetHeaderName);
            }
            if (!string.IsNullOrWhiteSpace(_handleHeader.GetHeaderValue()))
            {
                actionContext.Response.Headers.Add(_handleHeader.GetHeaderName, _handleHeader.GetHeaderValue());
            }
        }
    }
}
