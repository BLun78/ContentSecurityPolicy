using System.Collections.Generic;
using System.Text;

namespace Blun.ContentSecurityPolicy
{
    public sealed class ContentSecurityPolicyOptions
    {
        public List<string> DefaultSrc { get; internal set; } = new List<string>();
        public List<string> ScriptSrc { get; internal set; } = new List<string>();
        public List<string> StyleSrc { get; internal set; } = new List<string>();
        public List<string> ImgSrc { get; internal set; } = new List<string>();
        public List<string> FontSrc { get; internal set; } = new List<string>();
        public List<string> MediaSrc { get; internal set; } = new List<string>();
        public List<string> ConnectSrc { get; internal set; } = new List<string>();
        public List<string> FrameSrc { get; internal set; } = new List<string>();

        public string CreateCspHeaderValue()
        {
            var value = new StringBuilder();
            value.Append(GetDirective("default-src", this.DefaultSrc));
            value.Append(GetDirective("script-src", this.ScriptSrc));
            value.Append(GetDirective("style-src", this.StyleSrc));
            value.Append(GetDirective("img-src", this.ImgSrc));
            value.Append(GetDirective("font-src", this.FontSrc));
            value.Append(GetDirective("media-src", this.MediaSrc));
            value.Append(GetDirective("connect-src", this.ConnectSrc));
            value.Append(GetDirective("frame-src", this.FrameSrc));
            return value.ToString();
        }

        private static string GetDirective(string directive, List<string> sources)
            => sources.Count > 0
                ? $"{directive} {string.Join(" ", sources)}; "
                : "";
    }
}