using RoslynHelpers._Internals.ResourceResolving;


namespace RoslynHelpers.GenericLocalizableResourceString;

public readonly struct AnalyzerTitle : ISemanticOf
{
    public readonly string ResolveFrom<TResource>() where TResource : class
        => DiagnosticDescriptorResourceResolver<TResource>.ForTitle();
}