namespace ViewEngineIntegrationTesting.ViewEngines.Razor.UsingHelpers.View
{
    public class UsingHelpersEndpoint
    {
        public UsingHelpersModel Get(UsingHelpersInput input)
        {
            return new UsingHelpersModel { Message = "Hello from endpoint" };
        }
    }

    public class UsingHelpersInput
    {
    }

    public class UsingHelpersModel
    {
        public string Message { get; set; }
    }
}