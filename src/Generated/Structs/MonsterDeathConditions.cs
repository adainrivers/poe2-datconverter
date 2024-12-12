namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MonsterDeathConditions
{
	[FieldOffset(0)]
	public StringReference Unk000;

	[FieldOffset(8)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk001;

	[FieldOffset(24)]
	public TBool Unk002;

	[FieldOffset(25)]
	public int Unk003;

	[FieldOffset(29)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk004;

	[FieldOffset(45)]
	public TBool Unk005;

	[FieldOffset(46)]
	public int Unk006;

	[FieldOffset(50)]
	public TableReference Unk007;

	[FieldOffset(66)]
	public TBool Unk008;

	[FieldOffset(67)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk009;

	[FieldOffset(83)]
	public int Unk010;

	[FieldOffset(87)]
	public TBool Unk011;

	[FieldOffset(88)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk012;

	[FieldOffset(104)]
	public int Unk013;

	[FieldOffset(108)]
	public TableReference Unk014;

	[FieldOffset(124)]
	public TableReference Unk015;

	[FieldOffset(140)]
	public int Unk016;

	[FieldOffset(144)]
	public int Unk017;

}
