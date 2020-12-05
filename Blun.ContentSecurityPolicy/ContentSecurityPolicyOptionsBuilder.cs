using Blun.ContentSecurityPolicy.Directives;

namespace Blun.ContentSecurityPolicy
{
    public sealed class ContentSecurityPolicyOptionsBuilder
    {
        // https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Security-Policy

        private readonly ContentSecurityPolicyOptions _contentSecurityPolicyOptions = new ContentSecurityPolicyOptions();
        
        public DefaultSrcDirectiveBuilder DefaultSrc { get; internal set; } = new DefaultSrcDirectiveBuilder();
        public ScriptsSrcDirectiveBuilder ScriptSrc { get; internal set; } = new ScriptsSrcDirectiveBuilder();
        public StylesSrcDirectiveBuilder StyleSrc { get; internal set; } = new StylesSrcDirectiveBuilder();
        public ImgSrcDirectiveBuilder ImgSrc { get; internal set; } = new ImgSrcDirectiveBuilder();
        public FontSrcDirectiveBuilder FontSrc { get; internal set; } = new FontSrcDirectiveBuilder();
        public MediaSrcDirectiveBuilder MediaSrc { get; internal set; } = new MediaSrcDirectiveBuilder();
        public ConnectSrcDirectiveBuilder ConnectSrc { get; internal set; } = new ConnectSrcDirectiveBuilder();

        public ContentSecurityPolicyOptions Build()
        {
            _contentSecurityPolicyOptions.DefaultSrc.Clear();
            _contentSecurityPolicyOptions.ScriptSrc.Clear();
            _contentSecurityPolicyOptions.StyleSrc.Clear();
            _contentSecurityPolicyOptions.ImgSrc.Clear();
            _contentSecurityPolicyOptions.FontSrc.Clear();
            _contentSecurityPolicyOptions.MediaSrc.Clear();
            _contentSecurityPolicyOptions.ConnectSrc.Clear();
            _contentSecurityPolicyOptions.DefaultSrc.AddRange(DefaultSrc.Sources);
            _contentSecurityPolicyOptions.ScriptSrc.AddRange(ScriptSrc.Sources);
            _contentSecurityPolicyOptions.StyleSrc.AddRange(StyleSrc.Sources);
            _contentSecurityPolicyOptions.ImgSrc.AddRange(ImgSrc.Sources);
            _contentSecurityPolicyOptions.FontSrc.AddRange(FontSrc.Sources);
            _contentSecurityPolicyOptions.MediaSrc.AddRange(MediaSrc.Sources);
            _contentSecurityPolicyOptions.ConnectSrc.AddRange(ConnectSrc.Sources);
            return _contentSecurityPolicyOptions;
        }
    }
}