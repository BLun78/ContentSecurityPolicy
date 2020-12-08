using System.Web.Http;

namespace Blun.Csp.MvcWebapi.TestApp.Controllers.Api
{
    public class TestController : ApiController
    {
        [HttpGet]
        public string GetTest()
        {
            return "Hello World!";
        }
    }
}
