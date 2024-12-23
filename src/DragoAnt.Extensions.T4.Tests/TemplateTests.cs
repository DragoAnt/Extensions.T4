namespace DragoAnt.Extensions.T4.Tests;

public sealed class TemplateTests
{
    private readonly VerifySettings _settings;


    public TemplateTests()
    {
        _settings = new VerifySettings();
        _settings.UseDirectory(".verify.expected");
    }

    [Fact]
    public Task TemplateGeneration()
    {
        var data = new TemplateTestData([1, 2, 3], "MyNamespace");
        var template = new TestTemplate
        {
            Data = data
        };
        var result = template.TransformText();

        return Verify(result, "cs", _settings);
    }
}