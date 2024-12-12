using System.Reflection;

namespace PoE2Converter.Generated;

public static class TypesFactory
{
    static TypesFactory()
    {
        var assembly = Assembly.GetAssembly(typeof(TypesFactory));

        foreach (var type in assembly!.GetTypes())
        {
            switch (type.Namespace)
            {
                case "PoE2Converter.Generated.Structs":
                    StructsMap[type.Name] = type;
                    break;
                case "PoE2Converter.Generated.Enums" when type.IsEnum:
                    Enums.Add(type);
                    break;
            }
        }
    }

    public static Dictionary<string, Type> StructsMap { get; } = new(StringComparer.OrdinalIgnoreCase);
	public static List<Type> Enums { get; } = [];
}
