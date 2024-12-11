namespace Extractor;

[AttributeUsage(AttributeTargets.Field)]
public class ReferenceTableAttribute(string tableName) : Attribute
{
    public string TableName { get; } = tableName;
}