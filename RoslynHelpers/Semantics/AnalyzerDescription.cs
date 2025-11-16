using RoslynHelpers.ResourceResolving;


namespace RoslynHelpers.Semantics;

public readonly struct AnalyzerDescription : ISemanticOf<string>
{
    public string ResolveFrom<TResourceSource>()
        => DiagnosticDescriptorResourceResolver<TResourceSource>.ForDescription();
}