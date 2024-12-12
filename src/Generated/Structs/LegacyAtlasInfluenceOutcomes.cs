namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct LegacyAtlasInfluenceOutcomes
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public int Unk001;

	[FieldOffset(12)]
	public int Unk002;

	[FieldOffset(16)]
	public int Unk003;

	[FieldOffset(20)]
	public int Unk004;

	[FieldOffset(24)]
	public TableReference Unk005;

	[FieldOffset(40)]
	[ElementType(typeof(int))]
	public ArrayReference Unk006;

}
