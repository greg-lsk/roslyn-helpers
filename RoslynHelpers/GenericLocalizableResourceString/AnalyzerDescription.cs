using RoslynHelpers._Internals.ResourceResolving;


namespace RoslynHelpers.GenericLocalizableResourceString;

public readonly struct AnalyzerDescription : ISemanticOf
{
    public string ResolveFrom<TResourceSource>() where TResourceSource : class
        => DiagnosticDescriptorResourceResolver<TResourceSource>.ForDescription();
}