using System;
using FubuMVC.Core;
using FubuMVC.TestingHarness;
using FubuTestingSupport;
using NUnit.Framework;
using ViewEngineIntegrationTesting.ViewEngines.Razor.UsingHelpers.HelpersMakeSureTheyEncodeHtml;
using ViewEngineIntegrationTesting.ViewEngines.Razor.UsingHelpers.HelperWithAttr;
using ViewEngineIntegrationTesting.ViewEngines.Razor.UsingHelpers.View;

namespace ViewEngineIntegrationTesting.ViewEngines.Razor.UsingHelpers
{
    [TestFixture]
    public class UsingHelpersIntegrationTester : FubuRegistryHarness
    {
        protected override void configure(FubuRegistry registry)
        {
            registry.Actions.IncludeType<UsingHelpersEndpoint>();
            registry.Actions.IncludeType<UsingHelpersWithAttrEndpoint>();
            registry.Actions.IncludeType<HelpersMakeSureTheyEncodeHtmlEndpoint>();
        }

        [Test]
        public void get_view_with_helper_render()
        {
            var text = endpoints.Get<UsingHelpersEndpoint>(x => x.Get(new UsingHelpersInput()))
                .ReadAsText();
            text.ShouldContain("<p>rendered by helper: helper message</p>");
        }

        [Test]
        public void get_view_with_attrHelper_render()
        {
            var text = endpoints.Get<UsingHelpersWithAttrEndpoint>(x => x.Get(new UsingHelpersWithAttrInput()))
                .ReadAsText();
            text.ShouldContain("<a href=\"helperWithAttribute\" class=\"helperWithAttribute test\">rendered by helper: helperWithAttribute</a>");
        }

        [Test]
        public void get_view_with_encodedHtmlHelper_render()
        {
            var text = endpoints.Get<HelpersMakeSureTheyEncodeHtmlEndpoint>(x => x.Get(new HelpersMakeSureTheyEncodeHtmlInput()))
                .ReadAsText();
            Console.WriteLine(text);
            text.ShouldNotContain("<script>alert('hi')</script>\"");
        }
    }
}