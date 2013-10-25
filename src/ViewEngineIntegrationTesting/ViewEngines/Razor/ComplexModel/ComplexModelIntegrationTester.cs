using FubuMVC.Core;
using FubuMVC.TestingHarness;
using FubuTestingSupport;
using NUnit.Framework;
using ViewEngineIntegrationTesting.ViewEngines.Razor.ComplexModel.View;

namespace ViewEngineIntegrationTesting.ViewEngines.Razor.ComplexModel
{
    [TestFixture]
    public class SettingAttributesIntegrationTester : FubuRegistryHarness
    {
        protected override void configure(FubuRegistry registry)
        {
            registry.Actions.IncludeType<ComplexModelEndpoint>();
        }

        [Test]
        public void get_view_with_complexModel_render()
        {
            var text = endpoints.Get<ComplexModelEndpoint>(x => x.Get(new ComplexModelInputModel()))
                .ReadAsText();
            text.ShouldContain("<p>Test String</p><p></p>");
        }
    }
}