using System.Collections.Generic;

namespace Blun.ContentSecurityPolicy.Directives
{
    public abstract class BaseDirectiveBuilder
    {
        protected internal List<string> Sources { get; set; }

        protected BaseDirectiveBuilder()
        {
            Sources = new List<string>();
        }
    }
}