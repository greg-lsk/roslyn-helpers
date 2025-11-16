using RoslynHelpers.Semantics;
using RoslynHelpers.Descriptor.ResourceResolution;


namespace RoslynHelpers.Descriptor.Semantics;

public readonly struct AnalyzerDescription : ISemanticOf<string>
{
    public string ResolveFrom<TResourceSource>() => DiagnosticDescriptorResolver<TResourceSource>.ForDescription();
}