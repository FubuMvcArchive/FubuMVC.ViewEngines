using FubuMVC.Core;
using FubuMVC.TestingHarness;
using FubuTestingSupport;
using NUnit.Framework;
using ViewEngineIntegrationTesting.ViewEngines.Razor.ContextTests.View;
using ViewEngineIntegrationTesting.ViewEngines.Razor.UsingHelpers.HelperWithAttr;

namespace ViewEngineIntegrationTesting.ViewEngines.Razor.ContextTests
{
    [TestFixture]
    public class ContextTestIntegrationTester : FubuRegistryHarness
    {
        protected override void configure(FubuRegistry registry)
        {
            registry.Actions.IncludeType<ContextTestEndpoint>();
        }

        [Test]
        public void get_view_with_helper_render()
        {
            var text = endpoints.Get<ContextTestEndpoint>(x => x.Get(new ContextTestInput())).ReadAsText();
            text.ShouldContain("context: True");
        }
    }
}