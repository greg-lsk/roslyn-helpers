namespace RoslynHelpers.GenericLocalizableResourceString;

public interface ISemanticOf
{
    public string ResolveFrom<TResourceSource>() where TResourceSource : class;
}