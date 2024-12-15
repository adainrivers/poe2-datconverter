namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ItemVisualIdentity
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference DDSFile;

	[FieldOffset(16)]
	public StringReference AOFile;

	[FieldOffset(24)]
	[ReferenceTable("SoundEffects")]
	public TableReference InventorySoundEffect;

	[FieldOffset(40)]
	public short HASH16;

	[FieldOffset(42)]
	public StringReference AOFile2;

    // Rest seems repetitive reference to the next row, so skipping for now

    //[FieldOffset(58)]
    ////[ReferenceTable("SoundEffects")]
    //public TableReference UnkRef01;

    //[FieldOffset(74)]
    //public StringReference UnkString02;

    //[FieldOffset(90)]
    //public StringReference UnkString03;

    //[FieldOffset(106)]
    //public StringReference UnkString04;

    //[FieldOffset(122)]
    //public StringReference UnkString05;

    //[FieldOffset(138)]
    //public StringReference UnkString06;

    //[FieldOffset(154)]
    //public StringReference UnkString07;

}
