namespace PoE2Converter;

internal static class Program
{
    private static void Main()
    {
        CSharpClassGenerator.Generate();
        ConvertMetadataFiles();
        ConvertCsdFiles();
        ConvertDataFiles(false);
        var languages = Directory.GetDirectories(Path.Combine(Config.ExtractedFilesPath, "data")).Select(d => d.Split("\\")[^1]);
        foreach (var language in languages)
        {
            ConvertDataFiles(false, language);

        }
    }

    private static void ConvertMetadataFiles()
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
            var outputPath = Path.Combine(Config.DataOutputPath, "xt", path + ".json");
            var directory = Path.GetDirectoryName(outputPath);
            Directory.CreateDirectory(directory!);
            var json = JsonConvert.SerializeObject(metadata, Formatting.Indented);
            File.WriteAllText(outputPath, json);
        }
    }

    private static void ConvertCsdFiles()
    {
        Console.WriteLine("Converting csd files");
        var files = Directory.GetFiles(Config.GetExtractedFilePath("metadata"), "*.csd", SearchOption.AllDirectories);
        var csdMap = files.Select(CsdParser.Parse).ToDictionary(csd => csd.Path);
        foreach (var (path, csd) in csdMap)
        {
            var outputPath = Path.Combine(Config.DataOutputPath, "csd", path + ".json");
            var directory = Path.GetDirectoryName(outputPath);
            Directory.CreateDirectory(directory!);
            var json = JsonConvert.SerializeObject(csd, Formatting.Indented);
            File.WriteAllText(outputPath, json);
        }
    }


    private static void ConvertDataFiles(bool saveRawData, string language = null)
    {
        if (saveRawData && Directory.Exists(Config.RawDataOutputPath))
        {
            Directory.Delete(Config.RawDataOutputPath, true);
        }

        if (language != null) Directory.CreateDirectory(Path.Combine(Config.DataOutputPath, "data", language));

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
            var serializer = new DatStructSerializer(reader, results);
            var json = serializer.SerializeStructs(reader.Rows);
            var outputPath = language == null ? Path.Combine(Config.DataOutputPath, "data", $"{fileName}.json") : Path.Combine(Config.DataOutputPath, "data", language, $"{fileName}.json");
            File.WriteAllText(outputPath, json);
        }
    }
}
