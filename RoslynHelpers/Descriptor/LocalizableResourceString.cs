using Microsoft.CodeAnalysis;
using RoslynHelpers.Semantics;
using RoslynHelpers.Descriptor.ResourceResolution;


namespace RoslynHelpers.Descriptor;

public static class LocalizableResourceString<TResource> where TResource : struct, ISemanticOf<string>
{
    public static LocalizableString From<TResourceSource>() where TResourceSource : class
    {
        return new LocalizableResourceString
        (
            nameOfLocalizableResource: new TResource().ResolveFrom<TResourceSource>(),
            resourceManager:           DiagnosticDescriptorResolver<TResourceSource>.ForResourceManager(),
            resourceSource:            typeof(TResourceSource)
        );
    }

    public static LocalizableString From<TResourceSource>(params string[] formatArguments)
        where TResourceSource : class
    {
        return new LocalizableResourceString
        (
            nameOfLocalizableResource: new TResource().ResolveFrom<TResourceSource>(),
            resourceManager:           DiagnosticDescriptorResolver<TResourceSource>.ForResourceManager(),
            resourceSource:            typeof(TResourceSource),
            formatArguments:           formatArguments
        );
    }
}