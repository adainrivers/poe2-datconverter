namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AlternatePassiveSkills
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("AlternateTreeVersions")]
	public TableReference AlternateTreeVersionsKey;

	[FieldOffset(24)]
	public StringReference Name;

	[FieldOffset(32)]
	[ElementType(typeof(int))]
	public ArrayReference PassiveType;

	[FieldOffset(48)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TableReference))]
	public ArrayReference StatsKeys;

	[FieldOffset(64)]
	public int Stat1Min;

	[FieldOffset(68)]
	public int Stat1Max;

	[FieldOffset(72)]
	public int Stat2Min;

	[FieldOffset(76)]
	public int Stat2Max;

	[FieldOffset(80)]
	public int Unk009;

	[FieldOffset(84)]
	public int Unk010;

	[FieldOffset(88)]
	public int Unk011;

	[FieldOffset(92)]
	public int Unk012;

	[FieldOffset(96)]
	public int Unk013;

	[FieldOffset(100)]
	public int Unk014;

	[FieldOffset(104)]
	public int Unk015;

	[FieldOffset(108)]
	public int Unk016;

	[FieldOffset(112)]
	public int SpawnWeight;

	[FieldOffset(116)]
	public int Unk018;

	[FieldOffset(120)]
	public int RandomMin;

	[FieldOffset(124)]
	public int RandomMax;

	[FieldOffset(128)]
	public StringReference FlavourText;

	[FieldOffset(136)]
	public StringReference DDSIcon;

	[FieldOffset(144)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference AchievementItemsKeys;

	[FieldOffset(160)]
	public int Unk024;

	[FieldOffset(164)]
	public int Unk025;

}
