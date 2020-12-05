using Blun.ContentSecurityPolicy.Directives;

namespace Blun.ContentSecurityPolicy
{
    public sealed class ContentSecurityPolicyOptionsBuilder
    {
        // https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Security-Policy

        private readonly ContentSecurityPolicyOptions _contentSecurityPolicyOptions = new ContentSecurityPolicyOptions();

        public ContentSecurityPolicyOptionsBuilder() { }

        public DefaultSrcDirectiveBuilder Defaults { get; set; } = new DefaultSrcDirectiveBuilder();
        public ScriptsSrcDirectiveBuilder Scripts { get; set; } = new ScriptsSrcDirectiveBuilder();
        //public ContentSecurityPolicyOptionsDirectiveBuilder Styles { get; set; } = new ContentSecurityPolicyOptionsDirectiveBuilder();
        //public ContentSecurityPolicyOptionsDirectiveBuilder Images { get; set; } = new ContentSecurityPolicyOptionsDirectiveBuilder();
        //public ContentSecurityPolicyOptionsDirectiveBuilder Fonts { get; set; } = new ContentSecurityPolicyOptionsDirectiveBuilder();
        //public ContentSecurityPolicyOptionsDirectiveBuilder Media { get; set; } = new ContentSecurityPolicyOptionsDirectiveBuilder();

        public ContentSecurityPolicyOptions Build()
        {
            _contentSecurityPolicyOptions.Defaults.Clear();
            _contentSecurityPolicyOptions.Scripts.Clear();
            _contentSecurityPolicyOptions.Styles.Clear();
            _contentSecurityPolicyOptions.Images.Clear();
            _contentSecurityPolicyOptions.Fonts.Clear();
            _contentSecurityPolicyOptions.Media.Clear();
            _contentSecurityPolicyOptions.Defaults.AddRange(Defaults.Sources);
            _contentSecurityPolicyOptions.Scripts.AddRange(Scripts.Sources);
            //_contentSecurityPolicyOptions.Styles.AddRange(Styles.Sources);
            //_contentSecurityPolicyOptions.Images.AddRange(Images.Sources);
            //_contentSecurityPolicyOptions.Fonts.AddRange(Fonts.Sources);
            //_contentSecurityPolicyOptions.Media.AddRange(Media.Sources);
            return _contentSecurityPolicyOptions;
        }
    }
}