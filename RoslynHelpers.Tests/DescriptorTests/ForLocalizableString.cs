using Microsoft.CodeAnalysis;
using RoslynHelpers.Tests._Common;
using RoslynHelpers.Descriptor;
using RoslynHelpers.Descriptor.Semantics;


namespace RoslynHelpers.Tests.DescriptorTests;

public class ForLocalizableString
{
    [Fact]
    internal void SameResultYield_AsConventionalCtor_ForTitle()
    {
        var expected = CreateLocalizableResourceStringConventionally(nameof(StubResources.AnalyzerTitle));
        var expectedFormatted = CreateLocalizableResourceStringConventionally(nameof(StubResources.AnalyzerTitle), _stubFormat);

        var custom = LocalizableResourceString<AnalyzerTitle>.From<StubResources>();
        var customFormatted = LocalizableResourceString<AnalyzerTitle>.From<StubResources>(_stubFormat);

        Assert.Equal(expected, custom);
        Assert.Equal(expectedFormatted, customFormatted);
    }

    [Fact]
    internal void SameResultYield_AsConventionalCtor_ForDescription()
    {
        var expected = CreateLocalizableResourceStringConventionally(nameof(StubResources.AnalyzerDescription));
        var expectedFormatted = CreateLocalizableResourceStringConventionally(nameof(StubResources.AnalyzerDescription), _stubFormat);

        var custom = LocalizableResourceString<AnalyzerDescription>.From<StubResources>();
        var customFormatted = LocalizableResourceString<AnalyzerDescription>.From<StubResources>(_stubFormat);

        Assert.Equal(expected, custom);
        Assert.Equal(expectedFormatted, customFormatted);
    }

    [Fact]
    internal void SameResultYield_AsConventionalCtor_ForMessageFormat()
    {
        var expected = CreateLocalizableResourceStringConventionally(nameof(StubResources.AnalyzerMessageFormat));
        var expectedFormatted = CreateLocalizableResourceStringConventionally(nameof(StubResources.AnalyzerMessageFormat), _stubFormat);

        var custom = LocalizableResourceString<AnalyzerMessageFormat>.From<StubResources>();
        var customFormatted = LocalizableResourceString<AnalyzerMessageFormat>.From<StubResources>(_stubFormat);

        Assert.Equal(expected, custom);
        Assert.Equal(expectedFormatted, customFormatted);
    }


    private readonly static string[] _stubFormat = ["stub", "format"]; 
    private delegate LocalizableResourceString ConventionalLocalizableResourceStringCreation(string resourceName, string[]? format = null);

    private static ConventionalLocalizableResourceStringCreation CreateLocalizableResourceStringConventionally =>
    (string resourceName, string[]? format = null) =>
    {
        return format is null ? new(resourceName, StubResources.ResourceManager, typeof(StubResources)) 
                                : new(resourceName, StubResources.ResourceManager, typeof(StubResources), format);
    };
}