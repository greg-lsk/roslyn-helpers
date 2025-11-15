using Microsoft.CodeAnalysis;
using RoslynHelpers.LocalizableResource;
using RoslynHelpers._Internals.ResourceResolving;


namespace RoslynHelpers.Tests.LocalizableResource.TestData;

internal static class LocalizableStringTestData
{
    private static readonly string[] _dummyFormat = ["asdasda", "vvvv"];


    internal static TheoryData<Func<string>, string> IResourceRetrieval_ExpectedSourceResourceMember_Data => new()
    {
        {() => new AnalyzerTitle().GetFrom<TestResources>(), nameof(TestResources.AnalyzerTitle)},
        {() => new AnalyzerDescription().GetFrom<TestResources>(), nameof(TestResources.AnalyzerDescription)},
        {() => new AnalyzerMessageFormat().GetFrom<TestResources>(), nameof(TestResources.AnalyzerMessageFormat)}
    };


    internal static TheoryData<Func<LocalizableString>, Func<LocalizableString>> FromCustomAPI_FromConventionalCtor_Data => new()
    {
        {
            LocalizableStringHelper.From<TestResources, AnalyzerTitle>, 
            () => new LocalizableResourceString
            (
                ResourceIdentifiers.AnalyzerTitle,
                TestResources.ResourceManager,
                typeof(TestResources)
            )
        },
        {
            LocalizableStringHelper.From<TestResources, AnalyzerDescription>,
            () => new LocalizableResourceString
            (
                ResourceIdentifiers.AnalyzerDescription,
                TestResources.ResourceManager,
                typeof(TestResources)
            )
        },
        {
            LocalizableStringHelper.From<TestResources, AnalyzerMessageFormat>,
            () => new LocalizableResourceString
            (
                ResourceIdentifiers.AnalyzerMessageFormat,
                TestResources.ResourceManager,
                typeof(TestResources)
            )
        },
        {
            () => LocalizableStringHelper.From<TestResources, AnalyzerTitle>(_dummyFormat),
            () => new LocalizableResourceString
            (
                ResourceIdentifiers.AnalyzerTitle,
                TestResources.ResourceManager,
                typeof(TestResources),
                _dummyFormat
            )
        },
        {
            () => LocalizableStringHelper.From<TestResources, AnalyzerDescription>(_dummyFormat),
            () => new LocalizableResourceString
            (
                ResourceIdentifiers.AnalyzerDescription,
                TestResources.ResourceManager,
                typeof(TestResources),
                _dummyFormat
            )
        },
        {
            () => LocalizableStringHelper.From<TestResources, AnalyzerMessageFormat>(_dummyFormat),
            () => new LocalizableResourceString
            (
                ResourceIdentifiers.AnalyzerMessageFormat,
                TestResources.ResourceManager,
                typeof(TestResources),
                _dummyFormat
            )
        }
    };
}