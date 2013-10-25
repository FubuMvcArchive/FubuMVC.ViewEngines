namespace ViewEngineIntegrationTesting.ViewEngines.Razor.ComplexModel.View
{
    public class ComplexModelEndpoint
    {
        public ComplexModelViewModel Get(ComplexModelInputModel input)
        {
            return new ComplexModelViewModel { TestString = "Test String" };
        }
    }

    public class ComplexModelInputModel
    {
    }

    public class ComplexModelViewModel
    {
        public string TestString { get; set; }
        public string TestStringThatIsNull { get; set; }
    }
}