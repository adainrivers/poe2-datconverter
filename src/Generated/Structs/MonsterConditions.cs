namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MonsterConditions
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public TableReference Unk001;

	[FieldOffset(24)]
	public TableReference Unk002;

	[FieldOffset(40)]
	public TableReference Unk003;

	[FieldOffset(56)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk004;

	[FieldOffset(72)]
	public TBool Unk005;

	[FieldOffset(73)]
	public TBool Unk006;

	[FieldOffset(74)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk007;

	[FieldOffset(90)]
	[ElementType(typeof(StringReference))]
	public ArrayReference Unk008;

	[FieldOffset(106)]
	public int Unk009;

	[FieldOffset(110)]
	public int Unk010;

	[FieldOffset(114)]
	public int Unk011;

	[FieldOffset(118)]
	public int Unk012;

}
