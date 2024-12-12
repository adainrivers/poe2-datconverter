using Extractor.Generated;

namespace Extractor.Parsers;

public static class ReaderFactory
{
    public static DatReader GetReader(string name, ReadOnlySpan<byte> data)
    {
        var reader = new DatReader();
        if (TypesFactory.StructsMap.TryGetValue(name, out var type))
        {
            reader.Read(data, type);
            return reader;
        }
        Console.WriteLine($"Reader not found for {name}");
        reader.Read(data, null);
        return reader;
    }
}
