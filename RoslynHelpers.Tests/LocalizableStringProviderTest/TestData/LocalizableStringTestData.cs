using Microsoft.CodeAnalysis;
using RoslynHelpers.Tests._Common;
using RoslynHelpers.GenericLocalizableResourceString;
using RoslynHelpers.Semantics;
using RoslynHelpers.ResourceResolving;


namespace RoslynHelpers.Tests.LocalizableResource.TestData;

internal static class LocalizableStringTestData
{
    private static readonly string[] _dummyFormat = ["asdasda", "vvvv"];

    internal static TheoryData<Func<LocalizableString>, Func<LocalizableString>> FromCustomAPI_FromConventionalCtor_Data => new()
    {
        {
            LocalizableResourceString<AnalyzerTitle>.From<StubResources>, 
            () => new LocalizableResourceString
            (
                ResourceIdentifiers.AnalyzerTitle,
                StubResources.ResourceManager,
                typeof(StubResources)
            )
        },
        {
            LocalizableResourceString<AnalyzerDescription>.From<StubResources>,
            () => new LocalizableResourceString
            (
                ResourceIdentifiers.AnalyzerDescription,
                StubResources.ResourceManager,
                typeof(StubResources)
            )
        },
        {
            LocalizableResourceString<AnalyzerMessageFormat>.From<StubResources>,
            () => new LocalizableResourceString
            (
                ResourceIdentifiers.AnalyzerMessageFormat,
                StubResources.ResourceManager,
                typeof(StubResources)
            )
        },
        {
            () => LocalizableResourceString<AnalyzerTitle>.From<StubResources>(_dummyFormat),
            () => new LocalizableResourceString
            (
                ResourceIdentifiers.AnalyzerTitle,
                StubResources.ResourceManager,
                typeof(StubResources),
                _dummyFormat
            )
        },
        {
            () => LocalizableResourceString<AnalyzerDescription>.From<StubResources>(_dummyFormat),
            () => new LocalizableResourceString
            (
                ResourceIdentifiers.AnalyzerDescription,
                StubResources.ResourceManager,
                typeof(StubResources),
                _dummyFormat
            )
        },
        {
            () =>LocalizableResourceString<AnalyzerMessageFormat>.From<StubResources>(_dummyFormat),
            () => new LocalizableResourceString
            (
                ResourceIdentifiers.AnalyzerMessageFormat,
                StubResources.ResourceManager,
                typeof(StubResources),
                _dummyFormat
            )
        }
    };
}