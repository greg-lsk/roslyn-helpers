using RoslynHelpers.Tests.LocalizableResource.TestData;


namespace RoslynHelpers.Tests.LocalizableResource;

public class IResourceTests
{
    public static TheoryData<Func<string>, string> IResourceRetrieval_ExpectedSourceResourceMember
        => LocalizableStringTestData.IResourceRetrieval_ExpectedSourceResourceMember_Data;


    [Theory]
    [MemberData(nameof(IResourceRetrieval_ExpectedSourceResourceMember))]
    internal void IResource_CorrectlyMapsTo_ResourceProperty(Func<string> retrieval, string expectedValue)
    {
        Assert.Equal(expectedValue, retrieval());
    }
}