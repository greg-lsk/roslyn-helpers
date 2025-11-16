using Microsoft.CodeAnalysis;
using RoslynHelpers._Internals.ResourceResolving;
using RoslynHelpers.GenericLocalizableResourceString;
using RoslynHelpers.Tests._Common;
using RoslynHelpers.Tests.LocalizableResource.TestData;


namespace RoslynHelpers.Tests.LocalizableStringProviderTest;

public class LocalizableStringTests
{
    public static TheoryData<Func<LocalizableString>, Func<LocalizableString>> FromCustomAPI_FromConventionalCtor
        => LocalizableStringTestData.FromCustomAPI_FromConventionalCtor_Data;


    [Theory]
    [MemberData(nameof(FromCustomAPI_FromConventionalCtor))]
    internal void CustomCreationMethod_YieldsSameResultsAs_ConventionalCtor(Func<LocalizableString> customCreation,
                                                                            Func<LocalizableString> conventionalCreation)
    {
        Assert.Equal(conventionalCreation(), customCreation());
    }
}