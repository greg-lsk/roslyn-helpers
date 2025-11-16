using Microsoft.CodeAnalysis;
using RoslynHelpers.Tests._Common;
using RoslynHelpers.LocalizableResource;
using RoslynHelpers._Internals.ResourceResolving;


namespace RoslynHelpers.Tests.LocalizableStringProviderTest.TestData;

internal static class LocalizableStringTestData
{
    private static readonly string[] _dummyFormat = ["asdasda", "vvvv"];

    internal static TheoryData<Func<LocalizableString>, Func<LocalizableString>> FromCustomAPI_FromConventionalCtor_Data => new()
    {
        {
            LocalizableStringHelper.From<StubResources, AnalyzerTitle>, 
            () => new LocalizableResourceString
            (
                ResourceIdentifiers.AnalyzerTitle,
                StubResources.ResourceManager,
                typeof(StubResources)
            )
        },
        {
            LocalizableStringHelper.From<StubResources, AnalyzerDescription>,
            () => new LocalizableResourceString
            (
                ResourceIdentifiers.AnalyzerDescription,
                StubResources.ResourceManager,
                typeof(StubResources)
            )
        },
        {
            LocalizableStringHelper.From<StubResources, AnalyzerMessageFormat>,
            () => new LocalizableResourceString
            (
                ResourceIdentifiers.AnalyzerMessageFormat,
                StubResources.ResourceManager,
                typeof(StubResources)
            )
        },
        {
            () => LocalizableStringHelper.From<StubResources, AnalyzerTitle>(_dummyFormat),
            () => new LocalizableResourceString
            (
                ResourceIdentifiers.AnalyzerTitle,
                StubResources.ResourceManager,
                typeof(StubResources),
                _dummyFormat
            )
        },
        {
            () => LocalizableStringHelper.From<StubResources, AnalyzerDescription>(_dummyFormat),
            () => new LocalizableResourceString
            (
                ResourceIdentifiers.AnalyzerDescription,
                StubResources.ResourceManager,
                typeof(StubResources),
                _dummyFormat
            )
        },
        {
            () => LocalizableStringHelper.From<StubResources, AnalyzerMessageFormat>(_dummyFormat),
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