using System.Collections.Generic;
using FubuMVC.Core.Registration;

namespace FubuMVC.Core.View
{
    public class AutoImportModelNamespacesConvention : IConfigurationAction
    {
        public void Configure(BehaviorGraph graph)
        {
            var settings = graph.Settings.Get<CommonViewNamespaces>();
            if (settings.AutoImportModelNamespaces)
            {
                graph.Actions().Each(a =>
                {
                    if (a.HasInput)
                    {
                        settings.Add(a.InputType().Namespace);
                    }
                    if (a.HasOutput)
                    {
                        settings.Add(a.OutputType().Namespace);
                    }
                });
            }
        }
    }
}