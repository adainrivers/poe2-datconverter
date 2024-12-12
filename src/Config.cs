namespace PoE2Converter;

internal static class Config
{
    public const string ExtractedFilesPath = @"F:\PoE2\Extracted";
    public const string DataOutputPath = @"F:\PoE2\Data";
    public const string RawDataOutputPath = @"F:\PoE2\RawData";
    public const string ModelsOutputPath = @"F:\PoE2\Development\PoE2\GameModels";

    public static string GetExtractedFilePath(params string[] internalPath)
    {
        var outputPath = internalPath.Aggregate(ExtractedFilesPath, Path.Combine);

        var directory = Path.GetDirectoryName(outputPath);
        Directory.CreateDirectory(directory!);
        return outputPath;
    }
}
