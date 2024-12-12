namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MonsterPackCounts
{
	[FieldOffset(0)]
	public TableReference Unk000;

	[FieldOffset(16)]
	public int Unk001;

	[FieldOffset(20)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk002;

	[FieldOffset(36)]
	public TBool Unk003;

	[FieldOffset(37)]
	[ElementType(typeof(int))]
	public ArrayReference Unk004;

}
