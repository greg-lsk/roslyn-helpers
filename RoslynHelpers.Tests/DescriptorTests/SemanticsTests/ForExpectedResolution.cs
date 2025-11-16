using RoslynHelpers.Tests._Common;
using RoslynHelpers.Descriptor.Semantics;


namespace RoslynHelpers.Tests.DescriptorTests.SemanticsTests;

public class ForExpectedResolution
{
    [Fact]
    internal void AnalyzerTitle_ResolvesAsExpected()
    {
        var calculated = new AnalyzerTitle().ResolveFrom<StubResources>();
        var expected = nameof(StubResources.AnalyzerTitle);

        Assert.Equal(expected, calculated);
    }

    [Fact]
    internal void AnalyzerDescription_ResolvesAsExpected()
    {
        var calculated = new AnalyzerDescription().ResolveFrom<StubResources>();
        var expected = nameof(StubResources.AnalyzerDescription);

        Assert.Equal(expected, calculated);
    }

    [Fact]
    internal void AnalyzerMessageFormat_ResolvesAsExpected()
    {
        var calculated = new AnalyzerMessageFormat().ResolveFrom<StubResources>();
        var expected = nameof(StubResources.AnalyzerMessageFormat);

        Assert.Equal(expected, calculated);
    }
}