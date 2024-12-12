namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AreaInfluenceDoodads
{
	[FieldOffset(0)]
	[ReferenceTable("Stats")]
	public TableReference StatsKey;

	[FieldOffset(16)]
	public int StatValue;

	[FieldOffset(20)]
	public float Unk002;

	[FieldOffset(24)]
	[ElementType(typeof(StringReference))]
	public ArrayReference AOFiles;

	[FieldOffset(40)]
	public int Unk004;

	[FieldOffset(44)]
	public TBool Unk005;

	[FieldOffset(45)]
	public StringReference Unk006;

	[FieldOffset(53)]
	[ReferenceTable("Stats")]
	public TableReference Unk007;

}
