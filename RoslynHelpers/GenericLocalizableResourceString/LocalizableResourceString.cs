using Microsoft.CodeAnalysis;
using RoslynHelpers._Internals.ResourceResolving;


namespace RoslynHelpers.GenericLocalizableResourceString;

public static class LocalizableResourceString<TResource> where TResource : struct, ISemanticOf
{
    public static LocalizableString From<TResourceSource>() where TResourceSource : class
    {
        return new LocalizableResourceString
        (
            nameOfLocalizableResource: new TResource().ResolveFrom<TResourceSource>(),
            resourceManager:           DiagnosticDescriptorResourceResolver<TResourceSource>.ForResourceManager(),
            resourceSource:            typeof(TResourceSource)
        );
    }

    public static LocalizableString From<TResourceSource>(params string[] formatArguments)
        where TResourceSource : class
    {
        return new LocalizableResourceString
        (
            nameOfLocalizableResource: new TResource().ResolveFrom<TResourceSource>(),
            resourceManager:           DiagnosticDescriptorResourceResolver<TResourceSource>.ForResourceManager(),
            resourceSource:            typeof(TResourceSource),
            formatArguments:           formatArguments
        );
    }
}