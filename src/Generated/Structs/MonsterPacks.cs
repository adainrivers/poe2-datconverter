namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MonsterPacks
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public int Unk001;

	[FieldOffset(12)]
	[ReferenceTable("WorldAreas")]
	[ElementType(typeof(TableReference))]
	public ArrayReference WorldAreasKeys;

	[FieldOffset(28)]
	public int Unk003;

	[FieldOffset(32)]
	public int Unk004;

	[FieldOffset(36)]
	public int BossMonsterSpawnChance;

	[FieldOffset(40)]
	public int BossMonsterCount;

	[FieldOffset(44)]
	[ReferenceTable("MonsterVarieties")]
	[ElementType(typeof(TableReference))]
	public ArrayReference BossMonster_MonsterVarietiesKeys;

	[FieldOffset(60)]
	public TBool Unk008;

	[FieldOffset(61)]
	[ElementType(typeof(int))]
	public ArrayReference Unk009;

	[FieldOffset(77)]
	[ElementType(typeof(StringReference))]
	public ArrayReference Unk010;

	[FieldOffset(93)]
	[ReferenceTable("Tags")]
	[ElementType(typeof(TableReference))]
	public ArrayReference TagsKeys;

	[FieldOffset(109)]
	public int MinLevel;

	[FieldOffset(113)]
	public int MaxLevel;

	[FieldOffset(117)]
	[ReferenceTable("Tags")]
	[ElementType(typeof(TableReference))]
	public ArrayReference WorldAreas2;

	[FieldOffset(133)]
	public int Unk015;

	[FieldOffset(137)]
	[ReferenceTable("PackFormation")]
	public TableReference PackFormation;

	[FieldOffset(153)]
	public int Unk017;

	[FieldOffset(157)]
	public TBool Unk018;

	[FieldOffset(158)]
	[ElementType(typeof(int))]
	public ArrayReference Unk019;

	[FieldOffset(174)]
	public TBool Unk020;

	[FieldOffset(175)]
	public TBool Unk021;

	[FieldOffset(176)]
	public TBool Unk022;

	[FieldOffset(177)]
	public TBool Unk023;

	[FieldOffset(178)]
	[ElementType(typeof(StringReference))]
	public ArrayReference Unk024;

	[FieldOffset(194)]
	[ReferenceTable("NecropolisPacks")]
	public TableReference NecropolisPack;

}
