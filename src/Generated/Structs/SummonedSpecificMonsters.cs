namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SummonedSpecificMonsters
{
	[FieldOffset(0)]
	public int Id;

	[FieldOffset(4)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference MonsterVarietiesKey;

	[FieldOffset(20)]
	public int Unk002;

	[FieldOffset(24)]
	public TableReference Unk003;

	[FieldOffset(40)]
	public TBool Unk004;

	[FieldOffset(41)]
	public TBool Unk005;

	[FieldOffset(42)]
	public int Unk006;

	[FieldOffset(46)]
	public int Unk007;

	[FieldOffset(50)]
	public TBool Unk008;

	[FieldOffset(51)]
	public TableReference Unk009;

	[FieldOffset(67)]
	public TableReference Unk010;

	[FieldOffset(83)]
	public int Unk011;

	[FieldOffset(87)]
	public TBool Unk012;

	[FieldOffset(88)]
	public int Unk013;

	[FieldOffset(92)]
	public StringReference Unk014;

	[FieldOffset(100)]
	public TBool Unk015;

	[FieldOffset(101)]
	public TBool Unk016;

	[FieldOffset(102)]
	public int Unk017;

}
