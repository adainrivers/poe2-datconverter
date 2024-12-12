using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Extractor.Parsers;

public class DatReader
{
    private static readonly byte[] DataSeparator = [0xBB, 0xBB, 0xBB, 0xBB, 0xBB, 0xBB, 0xBB, 0xBB];
    private const int RowsStartIndex = 4;
    public byte[] Data { get; private set; }
    public List<byte[]> RowBytes { get; } = [];
    public List<object> Rows { get; } = [];


    public unsafe void Read(ReadOnlySpan<byte> data, Type underlyingType)
    {
        var rowCount = BitConverter.ToInt32(data[..4]);
        if (rowCount == 0) return;

        var dataOffset = data.IndexOf(DataSeparator);
        Data = dataOffset == -1 ? [] : data[dataOffset..].ToArray();

        var rowsEndIndex = dataOffset == -1 ? data.Length : dataOffset;
        var rowsData = data[RowsStartIndex..rowsEndIndex];
        var rowLength = rowsData.Length / rowCount;
        for (var i = 0; i < rowCount; i++)
        {
            var rowData = rowsData[(i * rowLength)..((i + 1) * rowLength)];
            RowBytes.Add(rowData.ToArray());
        }

        if (underlyingType== null) return;

        var size = Marshal.SizeOf(underlyingType);
        if (rowLength < size)
        {
            Console.WriteLine($"{underlyingType.Name}: Row data length {rowLength} does not match struct size {size}.");
            return;
        }

        for (var i = 0; i < rowCount; i++)
        {
            var itemData = RowBytes[i].AsSpan();
            var pointer = Unsafe.AsPointer(ref MemoryMarshal.GetReference(itemData));
            var item = Marshal.PtrToStructure(new IntPtr(pointer), underlyingType);

            Rows.Add(item);
        }


    }
}
