namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ModEffectStats
{
	[FieldOffset(0)]
	[ReferenceTable("Stats")]
	public TableReference StatsKey;

	[FieldOffset(16)]
	[ReferenceTable("Tags")]
	[ElementType(typeof(TableReference))]
	public ArrayReference TagsKeys;

	[FieldOffset(32)]
	public TBool Unk002;

	[FieldOffset(33)]
	public int Unk003;

	[FieldOffset(37)]
	public TBool Unk004;

	[FieldOffset(38)]
	public TBool Unk005;

	[FieldOffset(39)]
	public TBool Unk006;

}
