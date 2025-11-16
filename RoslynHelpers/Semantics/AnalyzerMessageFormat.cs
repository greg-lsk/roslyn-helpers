using RoslynHelpers.ResourceResolving;


namespace RoslynHelpers.Semantics;

public readonly struct AnalyzerMessageFormat : ISemanticOf<string>
{
    public readonly string ResolveFrom<TResources>() => DiagnosticDescriptorResourceResolver<TResources>.ForMessageFormat();
}