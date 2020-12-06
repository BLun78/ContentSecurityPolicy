﻿using System.Collections.Generic;
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
        public FrameSrcDirectiveBuilder FrameSrc { get; internal set; } = new FrameSrcDirectiveBuilder();

        public ContentSecurityPolicyOptions Build()
        {
            ArrangeBuild(_contentSecurityPolicyOptions.DefaultSrc, DefaultSrc.Sources);
            ArrangeBuild(_contentSecurityPolicyOptions.ScriptSrc, ScriptSrc.Sources);
            ArrangeBuild(_contentSecurityPolicyOptions.StyleSrc, StyleSrc.Sources);
            ArrangeBuild(_contentSecurityPolicyOptions.ImgSrc, ImgSrc.Sources);
            ArrangeBuild(_contentSecurityPolicyOptions.FontSrc, FontSrc.Sources);
            ArrangeBuild(_contentSecurityPolicyOptions.MediaSrc, MediaSrc.Sources);
            ArrangeBuild(_contentSecurityPolicyOptions.ConnectSrc, ConnectSrc.Sources);
            ArrangeBuild(_contentSecurityPolicyOptions.FrameSrc, FrameSrc.Sources);
            return _contentSecurityPolicyOptions;
        }

        private void ArrangeBuild(List<string> directiveBuilderSource, List<string> source)
        {
            directiveBuilderSource.Clear();
            directiveBuilderSource.AddRange(source);
        }
    }
}