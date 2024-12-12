using PoE2Converter.Generated;

namespace PoE2Converter.Parsers;

public static class ReaderFactory
{
    public static DatReader GetReader(string name, ReadOnlySpan<byte> data)
    {
        var reader = new DatReader();
        if (TypesFactory.StructsMap.TryGetValue(name, out var type))
        {
            reader.Read(data, type, name);
            return reader;
        }
        Console.WriteLine($"{name}: Row data structure doesn't exist");
        reader.Read(data, null, name);
        return reader;
    }
}
