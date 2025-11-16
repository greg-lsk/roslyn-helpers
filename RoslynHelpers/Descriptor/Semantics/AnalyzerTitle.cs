using RoslynHelpers.Semantics;
using RoslynHelpers.Descriptor.ResourceResolution;


namespace RoslynHelpers.Descriptor.Semantics;

public readonly struct AnalyzerTitle : ISemanticOf<string>
{
    public readonly string ResolveFrom<TResource>() => DiagnosticDescriptorResolver<TResource>.ForTitle();
}