using FubuMVC.Core;
using FubuMVC.TestingHarness;
using FubuTestingSupport;
using NUnit.Framework;
using ViewEngineIntegrationTesting.ViewEngines.Razor.SettingAttributes.View;

namespace ViewEngineIntegrationTesting.ViewEngines.Razor.SettingAttributes
{
    [TestFixture]
    public class SettingAttributesIntegrationTester : FubuRegistryHarness
    {
        protected override void configure(FubuRegistry registry)
        {
            registry.Actions.IncludeType<SettingAttributesEndpoint>();
        }

        [Test]
        public void get_view_with_attrHelper_render()
        {
            var text = endpoints.Get<SettingAttributesEndpoint>(x => x.Get(new SettingAttributesInput()))
                .ReadAsText();
            text.ShouldContain("<a href=\"HelloFromSettingAttributes\" class=\"HelloFromSettingAttributes test\">rendered by helper: HelloFromSettingAttributes</a>");
        }
    }
}