namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct CoreLeagues
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public TBool Unk001;

	[FieldOffset(9)]
	public TBool Unk002;

	[FieldOffset(10)]
	[ReferenceTable("Stats")]
	public TableReference Unk003;

	[FieldOffset(26)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk004;

	[FieldOffset(42)]
	[ReferenceTable("Stats")]
	public TableReference Unk005;

	[FieldOffset(58)]
	[ReferenceTable("Stats")]
	public TableReference Unk006;

	[FieldOffset(74)]
	[ReferenceTable("Stats")]
	public TableReference Unk007;

	[FieldOffset(90)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk008;

	[FieldOffset(106)]
	[ReferenceTable("Stats")]
	public TableReference Unk009;

	[FieldOffset(122)]
	public TableReference Unk010;

	[FieldOffset(138)]
	public int Unk011;

	[FieldOffset(142)]
	public TBool Unk012;

	[FieldOffset(143)]
	[ReferenceTable("Stats")]
	public TableReference Unk013;

	[FieldOffset(159)]
	public TBool Unk014;

	[FieldOffset(160)]
	public TBool Unk015;

	[FieldOffset(161)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk016;

}
