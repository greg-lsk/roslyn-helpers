namespace RoslynHelpers.Semantics;

public interface ISemanticOf<T>
{
    public T ResolveFrom<TSource>();
}