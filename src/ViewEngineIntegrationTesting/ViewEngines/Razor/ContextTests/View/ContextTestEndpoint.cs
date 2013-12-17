namespace ViewEngineIntegrationTesting.ViewEngines.Razor.ContextTests.View
{
    public class ContextTestEndpoint
    {
        public ContextTestModel Get(ContextTestInput input)
        {
            return new ContextTestModel { Message = "Hello from endpoint" };
        }
    }

    public class ContextTestInput
    {
    }

    public class ContextTestModel
    {
        public string Message { get; set; }
    }
}