namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ArchnemesisModVisuals
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("MiscAnimated")]
	public TableReference Unk001;

	[FieldOffset(24)]
	public TableReference Unk002;

	[FieldOffset(40)]
	public TableReference Unk003;

	[FieldOffset(56)]
	[ReferenceTable("BuffVisuals")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk004;

	[FieldOffset(72)]
	[ReferenceTable("MonsterVarieties")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk005;

	[FieldOffset(88)]
	[ReferenceTable("MiscAnimated")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk006;

	[FieldOffset(104)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk007;

}
