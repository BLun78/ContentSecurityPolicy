using System;
using System.Collections.Generic;
using System.Text;
using Blun.ContentSecurityPolicy.Directives.Values;

namespace Blun.ContentSecurityPolicy.Directives
{
    public sealed class ReportUriDirectiveBuilder : BaseDirectiveBuilder,
        IReportingUri<ReportUriDirectiveBuilder>
    {
        private string _uri;

        public ReportUriDirectiveBuilder(): base()
        {
            _uri = string.Empty;
        }

        public ReportUriDirectiveBuilder SetReportingUri(string uri)
        {
            this.Sources.Add($"report-uri {uri} ;");
            return this;
        }

        public ReportUriDirectiveBuilder SetReportingUri(Uri uri)
        {
            return SetReportingUri(uri.ToString());
        }
    }
}
