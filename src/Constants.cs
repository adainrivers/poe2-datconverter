namespace Extractor;

public static class Constants
{
    public static readonly long Null = BitConverter.ToInt32([0xFE, 0xFE, 0xFE, 0xFE, 0xFE, 0xFE, 0xFE, 0xFE]);
    public static readonly byte[] StringNullTerminator = [0, 0, 0, 0];
}

