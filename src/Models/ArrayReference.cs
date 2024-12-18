using System.Runtime.CompilerServices;
using System.Text;

namespace PoE2Converter.Models;
public struct ArrayReference
{
    public long Count;
    public long Offset;


    public unsafe List<object> GetValues(DatReader reader, Type underlyingType)
    {
        var dataSection = reader.Data.AsSpan();
        if (Offset == Constants.Null) return null;
        if (Count <= 0 || Offset <= 0 || Offset > reader.Data.Length)
        {
            return [];
        }

        var results = new List<object>();

        var size = Marshal.SizeOf(underlyingType);
        var arrayDataLength = Count * size;
        if (arrayDataLength == 0) return [];
        if (arrayDataLength < 0 || arrayDataLength > reader.Data.Length || arrayDataLength + Offset > reader.Data.Length)
        {
            return [];
        }
        var arrayData = dataSection[(int)Offset..(int)(Offset + arrayDataLength)];


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