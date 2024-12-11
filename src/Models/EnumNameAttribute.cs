namespace Extractor;

internal class EnumNameAttribute(string enumName): Attribute
{
    public string EnumName { get; } = enumName;
}
