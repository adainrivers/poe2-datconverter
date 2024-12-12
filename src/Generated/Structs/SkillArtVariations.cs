namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SkillArtVariations
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk001;

	[FieldOffset(24)]
	[ElementType(typeof(int))]
	public ArrayReference Unk002;

	[FieldOffset(40)]
	[ElementType(typeof(int))]
	public ArrayReference Unk003;

	[FieldOffset(56)]
	[ElementType(typeof(int))]
	public ArrayReference Unk004;

	[FieldOffset(72)]
	[ElementType(typeof(StringReference))]
	public ArrayReference Variants;

	[FieldOffset(88)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk006;

	[FieldOffset(104)]
	[ElementType(typeof(int))]
	public ArrayReference Unk007;

	[FieldOffset(120)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk008;

	[FieldOffset(136)]
	public TableReference Unk009;

	[FieldOffset(152)]
	[ElementType(typeof(int))]
	public ArrayReference Unk010;

	[FieldOffset(168)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk011;

	[FieldOffset(184)]
	[ElementType(typeof(int))]
	public ArrayReference Unk012;

}
