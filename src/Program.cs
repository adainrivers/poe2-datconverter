using PoE2Converter.Parsers;

namespace PoE2Converter;

internal static class Program
{
    private const bool UpdateRepo = true;
    private static void Main()
    {
        CSharpClassGenerator.Generate();
        ConvertMetadataFiles();
        ConvertCsdFiles();
        ConvertDataFiles(false);
        if (!UpdateRepo) return;

        if (Directory.Exists(Path.Combine(Config.RepoDataOutputPath, "data"))) Directory.Delete(Path.Combine(Config.RepoDataOutputPath, "data"), true);
        if (Directory.Exists(Path.Combine(Config.RepoDataOutputPath, "csd"))) Directory.Delete(Path.Combine(Config.RepoDataOutputPath, "csd"), true);
        if (Directory.Exists(Path.Combine(Config.RepoDataOutputPath, "xt"))) Directory.Delete(Path.Combine(Config.RepoDataOutputPath, "xt"), true);

        ConvertMetadataFiles(true);
        ConvertCsdFiles(true);
        ConvertDataFiles(false, null, true);
        var languages = Directory.GetDirectories(Path.Combine(Config.ExtractedFilesPath, "data"))
            .Select(d => d.Split("\\")[^1]);
        foreach (var language in languages)
        {
            ConvertDataFiles(false, language, true);

        }
    }

    private static void ConvertMetadataFiles(bool updateRepo = false)
    {
        Console.WriteLine("Converting metadata files");
        var files = Directory.GetFiles(Config.GetExtractedFilePath("metadata"), "*.it", SearchOption.AllDirectories);
        var metadataMap = files.Select(MetadataParser.Parse).ToDictionary(metadata => metadata.Path);

        foreach (var (path, metadata) in metadataMap)
        {
            if (metadata.Extends == null) continue;
            var current = metadata;
            while (current.Extends != null && metadataMap.TryGetValue(current.Extends, out var parent))
            {
                current = MetadataParser.Merge(parent, current);
            }
            metadataMap[path] = current;
        }

        foreach (var (path, metadata) in metadataMap)
        {
            var json = JsonConvert.SerializeObject(metadata, Formatting.Indented);
            WriteFile(json, Config.DataOutputPath, "xt", path + ".json");

            if (updateRepo) WriteFile(json, Config.RepoDataOutputPath, "xt", path + ".json");
        }
    }

    private static void ConvertCsdFiles(bool updateRepo = false)
    {
        Console.WriteLine("Converting csd files");
        var files = Directory.GetFiles(Config.GetExtractedFilePath("metadata"), "*.csd", SearchOption.AllDirectories);
        var csdMap = files.Select(CsdParser.Parse).ToDictionary(csd => csd.Path);
        foreach (var (path, csd) in csdMap)
        {
            var json = JsonConvert.SerializeObject(csd, Formatting.Indented);
            WriteFile(json, Config.DataOutputPath, "csd", path + ".json");

            if (updateRepo) WriteFile(json, Config.RepoDataOutputPath, "csd", path + ".json");
        }
    }

    private static void WriteFile(string json, string basePath, params string[] pathParts)
    {
        basePath = pathParts.Aggregate(basePath, Path.Combine);
        var directory = Path.GetDirectoryName(basePath);
        Directory.CreateDirectory(directory!);
        File.WriteAllText(basePath, json);
    }


    private static void ConvertDataFiles(bool saveRawData, string language = null, bool updateRepo = false)
    {
        if (saveRawData && Directory.Exists(Config.RawDataOutputPath))
        {
            Directory.Delete(Config.RawDataOutputPath, true);
        }


        Console.WriteLine("Converting data files");
        var dataFilesPath = Path.Combine(Config.ExtractedFilesPath, "data");
        if (language != null)
        {
            dataFilesPath = Path.Combine(dataFilesPath, language);
        }
        var dataFiles = Directory.GetFiles(dataFilesPath, "*.datc64", SearchOption.TopDirectoryOnly);
        var results = new Dictionary<string, DatReader>(StringComparer.OrdinalIgnoreCase);
        foreach (var file in dataFiles)
        {
            var fileName = Path.GetFileNameWithoutExtension(file);

            var data = File.ReadAllBytes(file);
            var reader = ReaderFactory.GetReader(fileName, data);
            if (reader == null) continue;
            results[fileName] = reader;

            if (saveRawData)
            {
                var outputFolder = language == null ? Path.Combine(Config.RawDataOutputPath, fileName) : Path.Combine(Config.RawDataOutputPath, language, fileName);
                Directory.CreateDirectory(outputFolder);
                if (reader.Data != null) File.WriteAllBytes(Path.Combine(outputFolder, "_dataSection.bin"), reader.Data);

                for (var i = 0; i < reader.RowBytes.Count; i++)
                {
                    File.WriteAllBytes(Path.Combine(outputFolder, $"{i}.bin"), reader.RowBytes[i]);
                }
            }
        }
        foreach (var (fileName, reader) in results)
        {
            var serializer = new DatStructSerializer(reader, results, true);
            var json = serializer.SerializeStructs(reader.Rows);
            if (language == null)
            {
                WriteFile(json, Config.DataOutputPath, "data", $"{fileName}.json");
            }
            else
            {
                WriteFile(json, Config.DataOutputPath, "data", language, $"{fileName}.json");
            }

            if (updateRepo)
            {
                serializer = new DatStructSerializer(reader, results, false);
                json = serializer.SerializeStructs(reader.Rows);
                if (language == null)
                {
                    WriteFile(json, Config.RepoDataOutputPath, "data", $"{fileName}.json");
                }
                else
                {
                    WriteFile(json, Config.RepoDataOutputPath, "data", language, $"{fileName}.json");
                }
            }
        }
    }
}
