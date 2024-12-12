namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct TieredMicrotransactionsVisuals
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference MTX;

	[FieldOffset(16)]
	public int Tier;

	[FieldOffset(20)]
	public StringReference Description;

	[FieldOffset(28)]
	public StringReference DDSFile;

	[FieldOffset(36)]
	public int Unk004;

	[FieldOffset(40)]
	public StringReference Unk005;

}
