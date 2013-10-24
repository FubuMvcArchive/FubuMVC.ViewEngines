namespace ViewEngineIntegrationTesting.ViewEngines.Razor.UsingHelpers.HelperWithAttr
{
    public class UsingHelpersWithAttrEndpoint
    {
        public UsingHelpersWithAttrModel Get(UsingHelpersWithAttrInput input)
        {
            return new UsingHelpersWithAttrModel { Message = "Hello from UsingHelpersWithAttrModel" };
        }
    }

    public class UsingHelpersWithAttrInput
    {
    }

    public class UsingHelpersWithAttrModel
    {
        public string Message { get; set; }
    }
}