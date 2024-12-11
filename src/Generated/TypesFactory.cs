using System.Reflection;
using Extractor.Generated.Enums;
using Extractor.Generated.Structs;

namespace Extractor.Generated;

public static class TypesFactory
{
    static TypesFactory()
    {
        var assembly = Assembly.GetAssembly(typeof(TypesFactory));

        foreach (var type in assembly!.GetTypes())
        {
            switch (type.Namespace)
            {
                case "Extractor.Generated.Structs":
                    StructsMap[type.Name] = type;
                    break;
                case "Extractor.Generated.Enums" when type.IsEnum:
                    Enums.Add(type);
                    break;
            }
        }
    }

    public static Dictionary<string, Type> StructsMap { get; } = new(StringComparer.OrdinalIgnoreCase);
	public static List<Type> Enums { get; } = [];
}
