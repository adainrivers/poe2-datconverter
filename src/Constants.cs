namespace Extractor;

public static class Constants
{
    public static readonly long Null = BitConverter.ToInt64([0xFE, 0xFE, 0xFE, 0xFE, 0xFE, 0xFE, 0xFE, 0xFE]);
    public static readonly byte[] StringNullTerminator = [0, 0, 0, 0];
}

