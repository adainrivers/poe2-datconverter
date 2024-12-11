using Extractor.Parsers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Extractor;
public struct TArray
{
    public long Count;
    public long Offset;


    public unsafe List<object> GetValues(DatReader reader, Type underlyingType)
    {
        var dataSection = reader.Data.AsSpan();
        if (Offset == Constants.Null) return null;
        if (Count < 0)
        {
            //Console.WriteLine($"Array count is negative. Count: {Count}");
            return [];
        }

        var size = Marshal.SizeOf(underlyingType);
        var arrayDataLength = Count * size;
        if (arrayDataLength == 0) return [];
        if (arrayDataLength < 0 || Offset <= 0 || arrayDataLength > reader.Data.Length || Offset > reader.Data.Length || arrayDataLength + Offset > reader.Data.Length)
        {
            //Console.WriteLine($"Array out of bounds. Offset: {Offset}, Count: {Count}, Data Length: {reader.Data.Length}");
            return [];
        }
        var arrayData = dataSection[(int)Offset..(int)(Offset + arrayDataLength)];

        var results = new List<object>();
        for (var i = 0; i < Count; i++)
        {

            var itemData = arrayData[(i * size)..];
            var reference = Unsafe.AsPointer(ref MemoryMarshal.GetReference(itemData));
            var item = Marshal.PtrToStructure(new IntPtr(reference), underlyingType);


            results.Add(item);
        }

        return results;
    }
}