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
        public List<string> ManifestSrc { get; internal set; } = new List<string>();
        public List<string> ChildSrc { get; internal set; } = new List<string>();

        public string CreateCspHeaderValue()
        {
            var value = new StringBuilder();
            value.Append(GetDirective("default-src", DefaultSrc));
            value.Append(GetDirective("script-src", ScriptSrc));
            value.Append(GetDirective("style-src", StyleSrc));
            value.Append(GetDirective("img-src", ImgSrc));
            value.Append(GetDirective("font-src", FontSrc));
            value.Append(GetDirective("media-src", MediaSrc));
            value.Append(GetDirective("connect-src", ConnectSrc));
            value.Append(GetDirective("frame-src", FrameSrc));
            value.Append(GetDirective("manifest-src", ManifestSrc));
            value.Append(GetDirective("child-src", ChildSrc));
            return value.ToString();
        }

        private static string GetDirective(string directive, List<string> sources)
            => sources.Count > 0
                ? $"{directive} {string.Join(" ", sources)}; "
                : "";
    }
}