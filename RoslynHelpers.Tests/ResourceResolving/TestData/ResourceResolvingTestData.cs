using System.Resources;
using RoslynHelpers._Internals.ResourceResolving;
using RoslynHelpers.Tests.LocalizableResource.TestData;


namespace RoslynHelpers.Tests.ResourceResolving.TestData;

internal static class ResourceResolvingTestData
{
    internal static TheoryData<(Delegate BuilderResult, Type ExpectedResolverType)> BuilderReturnsExpectedResolver_Data => 
    [
        (
            BuilderResult:        ResolverBuilder<TestResources>.ValueOf<string>(ResourceIdentifiers.AnalyzerTitle),
            ExpectedResolverType: typeof(Resolver<TestResources, string>) 
        ),
        (
            BuilderResult:        ResolverBuilder<TestResources>.ValueOf<string>(ResourceIdentifiers.AnalyzerDescription),
            ExpectedResolverType: typeof(Resolver<TestResources, string>)
        ),
        (
            BuilderResult:        ResolverBuilder<TestResources>.ValueOf<string>(ResourceIdentifiers.AnalyzerMessageFormat),
            ExpectedResolverType: typeof(Resolver<TestResources, string>)
        ),
        (
            BuilderResult:        ResolverBuilder<TestResources>.ValueOf<ResourceManager>(ResourceIdentifiers.AnalyzerResourceManager),
            ExpectedResolverType: typeof(Resolver<TestResources, ResourceManager>)
        )
    ];
}