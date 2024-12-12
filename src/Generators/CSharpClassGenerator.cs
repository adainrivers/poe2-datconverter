using System.Reflection;
using System.Text;

namespace PoE2Converter.Generators;
public static class CSharpClassGenerator
{
    public static void Generate()
    {
        Console.WriteLine("Generating CSharp Files");
        var structTypes = TypesFactory.StructsMap.Values;

        foreach (var type in structTypes)
        {
            var fields = type.GetFields();
            var outputPath = Path.Combine(Config.ModelsOutputPath, "Models", $"{type.Name}.cs");

            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("// Resharper disable all");
            stringBuilder.AppendLine("using System;");
            stringBuilder.AppendLine("using System.Collections.Generic;");
            stringBuilder.AppendLine("using System.Text;");
            stringBuilder.AppendLine("using GameModels.Enums;");
            stringBuilder.AppendLine("using Newtonsoft.Json;");
            stringBuilder.AppendLine();
            stringBuilder.AppendLine($"namespace GameModels.Models;");
            stringBuilder.AppendLine($"public class {type.Name}: ITableRow");
            stringBuilder.AppendLine("{");
            stringBuilder.AppendLine($"\t[JsonProperty(\"RowIndex\")]");
            stringBuilder.AppendLine($"\tpublic int RowIndex {{ get; set; }}");
            for (var fieldIndex = 0; fieldIndex < fields.Length; fieldIndex++)
            {
                var field = fields[fieldIndex];
                var enumType = field.GetCustomAttribute<EnumNameAttribute>()?.EnumName ?? "int";
                var fieldName = field.Name;
                if (field.Name.StartsWith("Unk")) continue;
                if (fieldName == type.Name) fieldName = $"{fieldName}_{fieldIndex:000}";

                stringBuilder.AppendLine($"\t[JsonProperty(\"{fieldName}\")]");
                if (field.FieldType == typeof(ArrayReference))
                {
                    var elementType = field.GetCustomAttribute<ElementTypeAttribute>()?.Type ?? typeof(int);
                    var columnType = elementType.Name;
                    if(columnType == "TableReference") columnType = "TableReference";
                    if(columnType == "StringReference") columnType = "string";
                    if(columnType == "TEnum") columnType = enumType;
                    stringBuilder.AppendLine($"\tpublic List<{columnType}> {fieldName} {{ get; set; }} = new();");
                }
                else if (field.FieldType == typeof(StringReference))
                {
                    stringBuilder.AppendLine($"\tpublic string {fieldName} {{ get; set; }}");
                }
                else if (field.FieldType == typeof(TableReference))
                {
                    stringBuilder.AppendLine($"\tpublic TableReference {fieldName} {{ get; set; }}");
                }
                else if (field.FieldType == typeof(TBool))
                {
                    stringBuilder.AppendLine($"\tpublic bool {fieldName} {{ get; set; }}");
                }
                else if(field.FieldType == typeof(TEnum))
                {
                    stringBuilder.AppendLine($"\tpublic {enumType} {fieldName} {{ get; set; }}");
                }
                else
                {
                    stringBuilder.AppendLine($"\tpublic {field.FieldType.Name} {fieldName} {{ get; set; }}");
                }

            }
            stringBuilder.AppendLine("}");
            var code = stringBuilder.ToString();


            File.WriteAllText(outputPath, code);
        }


        foreach (var enumType in TypesFactory.Enums)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("using System;");
            stringBuilder.AppendLine("using System.Collections.Generic;");
            stringBuilder.AppendLine("using System.Text;");
            stringBuilder.AppendLine();
            stringBuilder.AppendLine($"namespace GameModels.Enums;");
            stringBuilder.AppendLine($"public enum {enumType.Name}");
            stringBuilder.AppendLine("{");

            var enumNames = Enum.GetNames(enumType);
            var enumValues = Enum.GetValues(enumType);

            for (var i = 0; i < enumNames.Length; i++)
            {
                var name = enumNames[i];
                var value = (int)enumValues.GetValue(i);
                if (!string.IsNullOrEmpty(name))
                    stringBuilder.AppendLine($"\t{name} = {value},");
            }


            stringBuilder.AppendLine("}");
            var code = stringBuilder.ToString();
            var enumEntryPath = Path.Combine(Config.ModelsOutputPath, "Enums", $"{enumType.Name}.cs");
            File.WriteAllText(enumEntryPath, code);
        }

        var mainBuilder = new StringBuilder();
        //using Newtonsoft.Json;

        //namespace GameModels;

        //public static class GameModel
        //{
        //}

        mainBuilder.AppendLine("using Newtonsoft.Json;");
        mainBuilder.AppendLine("using GameModels.Models;");
        mainBuilder.AppendLine();
        mainBuilder.AppendLine("namespace GameModels;");
        mainBuilder.AppendLine("public static class GameModel");
        mainBuilder.AppendLine("{");
        var duplicateCheck = new HashSet<string>();
        foreach (var structType in structTypes)
        {
            if (!duplicateCheck.Add(structType.Name)) continue;

            mainBuilder.AppendLine($"\tprivate static List<{structType.Name}> m_{structType.Name};");
            mainBuilder.AppendLine($"\tpublic static List<{structType.Name}> {structType.Name} => m_{structType.Name} ??= Loader.Load<{structType.Name}>();");
        }



        mainBuilder.AppendLine("}");
        File.WriteAllText(Path.Combine(Config.ModelsOutputPath, "GameModel.cs"), mainBuilder.ToString());
    }
}
