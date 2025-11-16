using RoslynHelpers.Semantics;
using RoslynHelpers.Descriptor.ResourceResolution;


namespace RoslynHelpers.Descriptor.Semantics;

public readonly struct AnalyzerMessageFormat : ISemanticOf<string>
{
    public readonly string ResolveFrom<TResources>() => DiagnosticDescriptorResolver<TResources>.ForMessageFormat();
}