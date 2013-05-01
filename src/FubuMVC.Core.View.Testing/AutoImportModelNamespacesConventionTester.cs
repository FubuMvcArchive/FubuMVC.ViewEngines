using FakeTestNamespaceForAutoImport;
using FubuMVC.Core.Registration;
using FubuTestingSupport;
using NUnit.Framework;

namespace FubuMVC.Core.View.Testing
{
    [TestFixture]
    public class AutoImportModelNamespacesConventionTester
    {
        private FubuRegistry _registry;

	[SetUp]
	public void Setup()
	{
            _registry = new FubuRegistry();
	    _registry.Policies.Add<AutoImportModelNamespacesConvention>();
            _registry.Actions.IncludeType<FakeController>();
	}

        [Test]
        public void when_auto_import_is_true_namespaces_are_added()
        {
            var graph = BehaviorGraph.BuildFrom(_registry);
            var commonViewNamespaces = graph.Settings.Get<CommonViewNamespaces>();
	    commonViewNamespaces.Namespaces.ShouldHaveTheSameElementsAs("FubuMVC.Core.View.Testing", "FakeTestNamespaceForAutoImport");
        }

        [Test]
        public void when_auto_import_is_false_namespaces_are_not_added()
        {
	    _registry.AlterSettings<CommonViewNamespaces>(x => x.DontAutoImportModelNamespaces());

            var graph = BehaviorGraph.BuildFrom(_registry);
            var commonViewNamespaces = graph.Settings.Get<CommonViewNamespaces>();
            commonViewNamespaces.Namespaces.ShouldHaveCount(0);
        }
    }

    public class FakeController
    {
        public FakeViewModel Execute(FakeInputModel input)
        {
            return new FakeViewModel();
        }
    }

    public class FakeInputModel
    {
    }

}

namespace FakeTestNamespaceForAutoImport
{
    public class FakeViewModel
    {
    }
}