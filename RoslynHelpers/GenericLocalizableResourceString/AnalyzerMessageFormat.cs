using RoslynHelpers._Internals.ResourceResolving;


namespace RoslynHelpers.GenericLocalizableResourceString;

public readonly struct AnalyzerMessageFormat : ISemanticOf
{
    public readonly string ResolveFrom<TResources>() where TResources : class
        => DiagnosticDescriptorResourceResolver<TResources>.ForMessageFormat();
}