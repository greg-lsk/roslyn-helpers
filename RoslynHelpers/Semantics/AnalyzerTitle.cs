using RoslynHelpers.ResourceResolving;


namespace RoslynHelpers.Semantics;

public readonly struct AnalyzerTitle : ISemanticOf<string>
{
    public readonly string ResolveFrom<TResource>() => DiagnosticDescriptorResourceResolver<TResource>.ForTitle();
}