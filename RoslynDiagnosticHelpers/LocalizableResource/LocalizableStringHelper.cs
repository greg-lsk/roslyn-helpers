using System.Resources;
using Microsoft.CodeAnalysis;


namespace RoslynHelpers.LocalizableResource;

public static class LocalizableStringHelper
{
    public static LocalizableString From<TResource, TResourceId>(ResourceManager manager)
        where TResource : class
        where TResourceId : struct, IResource
    {
        return new LocalizableResourceString(new TResourceId().GetFrom<TResource>(), manager, typeof(TResource));
    }

    public static LocalizableString From<TResource, TResourceId>(ResourceManager manager, params string[] formatArguments)
        where TResource : class
        where TResourceId : struct, IResource
    {
        return new LocalizableResourceString(new TResourceId().GetFrom<TResource>(), manager, typeof(TResource), formatArguments);
    }
}