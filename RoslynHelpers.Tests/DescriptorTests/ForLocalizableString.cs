using Microsoft.CodeAnalysis;
using RoslynHelpers.Tests._Common;
using RoslynHelpers.Descriptor;
using RoslynHelpers.Descriptor.Semantics;


namespace RoslynHelpers.Tests.DescriptorTests;

public class ForLocalizableString
{
    public static TheoryData<Func<LocalizableString>, string> CustomCreation_ResourceName_Data => new()
    {
        { LocalizableResourceString<AnalyzerTitle>.From<StubResources>,         nameof(StubResources.AnalyzerTitle) },
        { LocalizableResourceString<AnalyzerDescription>.From<StubResources>,   nameof(StubResources.AnalyzerDescription) },
        { LocalizableResourceString<AnalyzerMessageFormat>.From<StubResources>, nameof(StubResources.AnalyzerMessageFormat) }
    };
    [Theory]
    [MemberData(nameof(CustomCreation_ResourceName_Data))]
    internal void CustomCreation_YieldsSameResultsAs_ConventionalCtor(Func<LocalizableString> customCreation, string resourceName)
    {
        var custom = customCreation();
        var expected = new LocalizableResourceString
        (
            resourceName,
            StubResources.ResourceManager,
            typeof(StubResources)
        );

        Assert.Equal(expected, custom);
    }


    public static TheoryData<Func<string[], LocalizableString>, string> CustomCreationWithFormat_ResourceName_Data => new()
    {
        { LocalizableResourceString<AnalyzerTitle>.From<StubResources>,         nameof(StubResources.AnalyzerTitle) },
        { LocalizableResourceString<AnalyzerDescription>.From<StubResources>,   nameof(StubResources.AnalyzerDescription) },
        { LocalizableResourceString<AnalyzerMessageFormat>.From<StubResources>, nameof(StubResources.AnalyzerMessageFormat) }
    };
    [Theory]
    [MemberData(nameof(CustomCreationWithFormat_ResourceName_Data))]
    internal void CustomCreationWithFormat_YieldsSameResultsAs_ConventionalCtor(Func<string[], LocalizableString> customCreationWithFormat, string resourceName)
    {
        string[] stubFormat = ["stub", "format"];
        var custom = customCreationWithFormat(stubFormat);
        var expected = new LocalizableResourceString
        (
            resourceName,
            StubResources.ResourceManager,
            typeof(StubResources),
            stubFormat
        );

        Assert.Equal(expected, custom);
    }
}