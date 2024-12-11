using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using Extractor.Parsers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Extractor.Serialization;

public class DatStructSerializer
{
    private readonly DatReader _reader;
    private readonly StringWriter _writer;
    private readonly JsonTextWriter _jsonWriter;

    public DatStructSerializer(DatReader reader)
    {
        _reader = reader;
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
            _jsonWriter.WritePropertyName("RowIndex");
            _jsonWriter.WriteValue(i);
            foreach (var fieldInfo in fields)
            {
                if (fieldInfo.Name.StartsWith("Unk")) continue;

                _jsonWriter.WritePropertyName(fieldInfo.Name);
                var value = fieldInfo.GetValue(row);

                if (fieldInfo.FieldType == typeof(TArray))
                {
                    if (value == null)
                    {
                        _jsonWriter.WriteNull();
                        continue;
                    }

                    var elementType = fieldInfo.GetCustomAttribute<ElementTypeAttribute>()?.Type ?? typeof(int);
                    var array = (TArray)value;
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

    private void WriteFieldValue(Type fieldType, object value, IEnumerable<Attribute> attributes = null)
    {
        if (value == null)
        {
            _jsonWriter.WriteNull();
            return;
        }
        if (fieldType == typeof(TString))
        {
            _jsonWriter.WriteValue(((TString)value).GetValue(_reader));
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

        if (fieldType == typeof(TRef))
        {
            var tRefValue = (TRef)value;
            if (tRefValue.RowIndex == Constants.Null)
            {
                _jsonWriter.WriteNull();
                return;
            }
            var tableName = attributes?.Where(a => a.GetType() == typeof(ReferenceTableAttribute)).Cast<ReferenceTableAttribute>().FirstOrDefault()?.TableName;
            _jsonWriter.WriteStartObject();
            _jsonWriter.WritePropertyName("RowIndex");
            _jsonWriter.WriteValue(tRefValue.RowIndex);
            _jsonWriter.WritePropertyName("TableName");
            _jsonWriter.WriteValue(tableName);
            _jsonWriter.WriteEndObject();
            return;
        }

        _jsonWriter.WriteValue(value);
    }
}