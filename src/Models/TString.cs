using Extractor.Parsers;
using System.Text;

namespace Extractor;

public struct TString
{
    public long Offset;

    public string GetValue(DatReader reader)
    {
        var dataSection = reader.Data.AsSpan();
        if (Offset == Constants.Null) return null;
        if (Offset < 0 || Offset > reader.Data.Length)
        {
            //Console.WriteLine($"String out of bounds. Offset: {Offset}, Data Length: {reader.Data.Length}");
            return null;
        }
        var strBuffer = dataSection[(int)Offset..];
        var strLen = strBuffer.IndexOf(Constants.StringNullTerminator);
        if (strLen > 1024) strLen = 1024;
        if (strLen % 2 != 0)
            strLen++;
        return Encoding.Unicode.GetString(strBuffer[..strLen]);

    }
}