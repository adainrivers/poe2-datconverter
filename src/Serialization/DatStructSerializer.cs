using System.Reflection;

namespace PoE2Converter.Serialization;

public class DatStructSerializer
{
    private readonly DatReader _reader;
    private readonly Dictionary<string, DatReader> _allResults;
    private readonly bool _includeRowIndex;
    private readonly StringWriter _writer;
    private readonly JsonTextWriter _jsonWriter;

    public DatStructSerializer(DatReader reader, Dictionary<string, DatReader> allResults, bool includeRowIndex)
    {
        _reader = reader;
        _allResults = allResults;
        _includeRowIndex = includeRowIndex;
        _writer = new StringWriter();
        _jsonWriter = new JsonTextWriter(_writer);
        _jsonWriter.Formatting = Formatting.Indented;
        _jsonWriter.IndentChar = ' ';
        _jsonWriter.Indentation = 2;
    }


    public string SerializeStructs(List<object> rows)
    {
        if (rows.Count == 0) return "[]";

        var type = rows[0].GetType();
        var fields = type.GetFields();

        _jsonWriter.WriteStartArray();
        for (var i = 0; i < rows.Count; i++)
        {
            var row = rows[i];
            _jsonWriter.WriteStartObject();
            if (_includeRowIndex)
            {
                _jsonWriter.WritePropertyName("RowIndex");
                _jsonWriter.WriteValue(i);
            }

            foreach (var fieldInfo in fields)
            {
                //if (fieldInfo.Name.StartsWith("Unk")) continue;

                _jsonWriter.WritePropertyName(fieldInfo.Name);
                var value = fieldInfo.GetValue(row);

                if (fieldInfo.FieldType == typeof(ArrayReference))
                {
                    if (value == null)
                    {
                        _jsonWriter.WriteNull();
                        continue;
                    }

                    var elementType = fieldInfo.GetCustomAttribute<ElementTypeAttribute>()?.Type ?? typeof(int);
                    var array = (ArrayReference)value;
                    var values = array.GetValues(_reader, elementType);
                    if (values == null)
                    {
                        _jsonWriter.WriteNull();
                        continue;
                    }
                    _jsonWriter.WriteStartArray();
                    foreach (var arrayValue in values)
                    {
                        WriteFieldValue(elementType, arrayValue, fieldInfo.GetCustomAttributes<Attribute>());
                    }

                    _jsonWriter.WriteEndArray();

                    continue;
                }

                WriteFieldValue(fieldInfo.FieldType, value, fieldInfo.GetCustomAttributes<Attribute>());
            }

            _jsonWriter.WriteEndObject();
        }

        _jsonWriter.WriteEndArray();

        _jsonWriter.Flush();
        _writer.Flush();
        return _writer.ToString();
    }

    private void WriteFieldValue(Type fieldType, object value, IEnumerable<Attribute> attributes = null, DatReader overrideReader = null)
    {
        if (value == null)
        {
            _jsonWriter.WriteNull();
            return;
        }
        if (fieldType == typeof(StringReference))
        {
            _jsonWriter.WriteValue(((StringReference)value).GetValue(overrideReader ?? _reader));
            return;
        }

        if (fieldType == typeof(TEnum))
        {
            _jsonWriter.WriteValue(((TEnum)value).Index);
            return;

        }

        if (fieldType == typeof(TBool))
        {
            _jsonWriter.WriteValue(((TBool)value).Value == 1);
            return;

        }

        if (fieldType == typeof(TableReference))
        {
            var tableReferenceValue = (TableReference)value;
            if (tableReferenceValue.RowIndex == Constants.Null || tableReferenceValue.RowIndex < 0)
            {
                _jsonWriter.WriteNull();
                return;
            }
            var tableName = attributes?.Where(a => a.GetType() == typeof(ReferenceTableAttribute)).Cast<ReferenceTableAttribute>().FirstOrDefault()?.TableName;
            _jsonWriter.WriteStartObject();
            _jsonWriter.WritePropertyName("TableName");
            _jsonWriter.WriteValue(tableName);
            var foundId = false;
            if (tableName != null && _allResults.TryGetValue(tableName, out var tableReader))
            {
                if (tableReader.Rows.Count > tableReferenceValue.RowIndex)
                {
                    var refRow = tableReader.Rows[(int)tableReferenceValue.RowIndex];
                    var fieldName = "Id";
                    if (tableName == "Words")
                    {
                        fieldName = "Text";
                    }
                    var idField = refRow.GetType().GetField(fieldName);
                    if (idField != null)
                    {
                        _jsonWriter.WritePropertyName(fieldName);
                        WriteFieldValue(idField.FieldType, idField.GetValue(refRow), null, tableReader);
                        foundId = true;
                    }
                }
            }

            if (_includeRowIndex || !foundId)
            {
                _jsonWriter.WritePropertyName("RowIndex");
                _jsonWriter.WriteValue(tableReferenceValue.RowIndex);
            }

            _jsonWriter.WriteEndObject();
            return;
        }

        _jsonWriter.WriteValue(value);
    }
}