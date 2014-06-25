namespace ViewEngineIntegrationTesting.ViewEngines.Razor.UsingHelpers.HelpersMakeSureTheyEncodeHtml
{
    public class HelpersMakeSureTheyEncodeHtmlEndpoint
    {
        public HelpersMakeSureTheyEncodeHtmlModel Get(HelpersMakeSureTheyEncodeHtmlInput input)
        {
            return new HelpersMakeSureTheyEncodeHtmlModel { Message = "<script>alert('hi')</script>" };
        }
    }

    public class HelpersMakeSureTheyEncodeHtmlInput
    {
    }

    public class HelpersMakeSureTheyEncodeHtmlModel
    {
        public string Message { get; set; }
    }
}