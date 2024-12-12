namespace PoE2Converter.Models;

[AttributeUsage(AttributeTargets.Field)]
public class ElementTypeAttribute(Type type): Attribute
{
    public Type Type { get; } = type;
}