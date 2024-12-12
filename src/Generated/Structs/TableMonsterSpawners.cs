namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct TableMonsterSpawners
{
	[FieldOffset(0)]
	public StringReference Metadata;

	[FieldOffset(8)]
	public int AreaLevel;

	[FieldOffset(12)]
	[ReferenceTable("MonsterVarieties")]
	[ElementType(typeof(TableReference))]
	public ArrayReference SpawnsMonsters;

	[FieldOffset(28)]
	public int Unk003;

	[FieldOffset(32)]
	public int Unk004;

	[FieldOffset(36)]
	public int Unk005;

	[FieldOffset(40)]
	public int Unk006;

	[FieldOffset(44)]
	public int Unk007;

	[FieldOffset(48)]
	public int Unk008;

	[FieldOffset(52)]
	public int Unk009;

	[FieldOffset(56)]
	public int Unk010;

	[FieldOffset(60)]
	public TBool Unk011;

	[FieldOffset(61)]
	public TBool Unk012;

	[FieldOffset(62)]
	public TBool Unk013;

	[FieldOffset(63)]
	public TBool Unk014;

	[FieldOffset(64)]
	public TBool Unk015;

	[FieldOffset(65)]
	public TBool Unk016;

	[FieldOffset(66)]
	public int Unk017;

	[FieldOffset(70)]
	public int Unk018;

	[FieldOffset(74)]
	public int Unk019;

	[FieldOffset(78)]
	public int Unk020;

	[FieldOffset(82)]
	public TableReference Unk021;

	[FieldOffset(98)]
	public TBool Unk022;

	[FieldOffset(99)]
	public TBool Unk023;

	[FieldOffset(100)]
	public StringReference Script1;

	[FieldOffset(108)]
	public TBool Unk025;

	[FieldOffset(109)]
	public TBool Unk026;

	[FieldOffset(110)]
	public StringReference Script2;

	[FieldOffset(118)]
	[ElementType(typeof(int))]
	public ArrayReference Unk028;

	[FieldOffset(134)]
	public int Unk029;

	[FieldOffset(138)]
	public int Unk030;

	[FieldOffset(142)]
	public int Unk031;

	[FieldOffset(146)]
	public int Unk032;

	[FieldOffset(150)]
	public int Unk033;

	[FieldOffset(154)]
	public int Unk034;

	[FieldOffset(158)]
	public int Unk035;

	[FieldOffset(162)]
	public int Unk036;

}
