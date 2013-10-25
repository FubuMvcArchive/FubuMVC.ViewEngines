namespace ViewEngineIntegrationTesting.ViewEngines.Razor.SettingAttributes.View
{
    public class SettingAttributesEndpoint
    {
        public SettingAttributesModel Get(SettingAttributesInput input)
        {
            return new SettingAttributesModel { Message = "HelloFromSettingAttributes" };
        }
    }

    public class SettingAttributesInput
    {
    }

    public class SettingAttributesModel
    {
        public string Message { get; set; }
    }
}