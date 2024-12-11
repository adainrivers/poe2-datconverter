using Extractor.Generated;

namespace Extractor.Parsers;

public static class ReaderFactory
{
    public static DatReader GetReader(string name, ReadOnlySpan<byte> data)
    {
        if (TypesFactory.StructsMap.TryGetValue(name, out var type))
        {
            var reader = new DatReader();
            reader.Read(data, type);
            return reader;
        }
        Console.WriteLine($"Reader not found for {name}");
        return null;
    }
}
