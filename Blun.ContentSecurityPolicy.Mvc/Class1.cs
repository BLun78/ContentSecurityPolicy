using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Mvc;

namespace Blun.ContentSecurityPolicy.Mvc
{
    public class Class1:  
        global::System.Web.Http.Filters.IActionFilter, 
        global::System.Web.Mvc.IActionFilter
    {

        public Class1(
            ContentSecurityPolicyOptions contentSecurityPolicyOptions)
        {
                
        }

        public bool AllowMultiple { get; }

        public Task<HttpResponseMessage> ExecuteActionFilterAsync(HttpActionContext actionContext, CancellationToken cancellationToken, Func<Task<HttpResponseMessage>> continuation)
        {
            throw new NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            throw new NotImplementedException();
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            throw new NotImplementedException();
        }
    }
}
