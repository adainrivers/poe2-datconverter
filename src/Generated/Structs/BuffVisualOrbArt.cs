namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BuffVisualOrbArt
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("MiscAnimated")]
	public TableReference MiscAnimated;

	[FieldOffset(24)]
	[ElementType(typeof(int))]
	public ArrayReference Unk002;

	[FieldOffset(40)]
	[ElementType(typeof(StringReference))]
	public ArrayReference Unk003;

	[FieldOffset(56)]
	public StringReference Unk004;

	[FieldOffset(64)]
	public StringReference Unk005;

	[FieldOffset(72)]
	public StringReference Unk006;

	[FieldOffset(80)]
	public StringReference Unk007;

	[FieldOffset(88)]
	public int Unk008;

	[FieldOffset(92)]
	public TableReference Unk009;

	[FieldOffset(108)]
	public TableReference Unk010;

	[FieldOffset(124)]
	public TableReference Unk011;

	[FieldOffset(140)]
	public TableReference Unk012;

	[FieldOffset(156)]
	public TBool Unk013;

	[FieldOffset(157)]
	public int Unk014;

}
