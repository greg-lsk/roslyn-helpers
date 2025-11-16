using RoslynHelpers.Tests._Common;
using RoslynHelpers.GenericLocalizableResourceString;


namespace RoslynHelpers.Tests.IResourceTests;

public class ForExpectedInstantiation
{
    [Fact]
    internal void AnalyzerTitle_InstantiatesAsExpected()
    {
        var calculated = new AnalyzerTitle().ResolveFrom<StubResources>();
        var expected = nameof(StubResources.AnalyzerTitle);

        Assert.Equal(expected, calculated);
    }

    [Fact]
    internal void AnalyzerDescription_InstantiatesAsExpected()
    {
        var calculated = new AnalyzerDescription().ResolveFrom<StubResources>();
        var expected = nameof(StubResources.AnalyzerDescription);

        Assert.Equal(expected, calculated);
    }

    [Fact]
    internal void AnalyzerMessageFormat_InstantiatesAsExpected()
    {
        var calculated = new AnalyzerMessageFormat().ResolveFrom<StubResources>();
        var expected = nameof(StubResources.AnalyzerMessageFormat);

        Assert.Equal(expected, calculated);
    }
}