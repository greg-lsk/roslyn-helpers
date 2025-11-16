using RoslynHelpers.Tests._Common;
using RoslynHelpers._Internals.ResourceResolving;


namespace RoslynHelpers.Tests.DiagnosticDescriptorResourceResolverTests;

public class NecessaryForSuccesfullCreation
{
    [Fact]
    public void ForTitle_InitializesCorrectly()
    {
        var calculated = DiagnosticDescriptorResourceResolver<StubResources>.ForTitle();
        var expected = nameof(StubResources.AnalyzerTitle);

        Assert.Equal(expected, calculated);
    }

    [Fact]
    public void ForDescription_InitializesCorrectly()
    {
        var calculated = DiagnosticDescriptorResourceResolver<StubResources>.ForDescription();
        var expected = nameof(StubResources.AnalyzerDescription);

        Assert.Equal(expected, calculated);
    }

    [Fact]
    public void ForMessageFormat_InitializesCorrectly()
    {
        var calculated = DiagnosticDescriptorResourceResolver<StubResources>.ForMessageFormat();
        var expected = nameof(StubResources.AnalyzerMessageFormat);

        Assert.Equal(expected, calculated);
    }

    [Fact]
    public void ForResourceManager_InitializesCorrectly()
    {
        var calculated = DiagnosticDescriptorResourceResolver<StubResources>.ForResourceManager();
        var expected = StubResources.ResourceManager;

        Assert.Equal(expected, calculated);
    }
}