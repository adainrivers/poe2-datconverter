namespace PoE2Converter.Models;

internal class EnumNameAttribute(string enumName): Attribute
{
    public string EnumName { get; } = enumName;
}
