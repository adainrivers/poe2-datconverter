namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct PantheonPanelLayout
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public int X;

	[FieldOffset(12)]
	public int Y;

	[FieldOffset(16)]
	public TBool IsMajorGod;

	[FieldOffset(17)]
	public StringReference CoverImage;

	[FieldOffset(25)]
	public StringReference GodName2;

	[FieldOffset(33)]
	public StringReference SelectionImage;

	[FieldOffset(41)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Effect1_StatsKeys;

	[FieldOffset(57)]
	[ElementType(typeof(int))]
	public ArrayReference Effect1_Values;

	[FieldOffset(73)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Effect2_StatsKeys;

	[FieldOffset(89)]
	public StringReference GodName3;

	[FieldOffset(97)]
	[ElementType(typeof(int))]
	public ArrayReference Effect3_Values;

	[FieldOffset(113)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Effect3_StatsKeys;

	[FieldOffset(129)]
	public StringReference GodName4;

	[FieldOffset(137)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Effect4_StatsKeys;

	[FieldOffset(153)]
	[ElementType(typeof(int))]
	public ArrayReference Effect4_Values;

	[FieldOffset(169)]
	public StringReference GodName1;

	[FieldOffset(177)]
	[ElementType(typeof(int))]
	public ArrayReference Effect2_Values;

	[FieldOffset(193)]
	[ReferenceTable("QuestFlags")]
	public TableReference QuestFlag;

	[FieldOffset(209)]
	public TBool IsDisabled;

	[FieldOffset(210)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference AchievementItems;

	[FieldOffset(226)]
	public int LeagueQuestFlag1;

	[FieldOffset(230)]
	public int LeagueQuestFlag2;

	[FieldOffset(234)]
	public int LeagueQuestFlag3;

	[FieldOffset(238)]
	[ReferenceTable("QuestFlags")]
	public TableReference DowngradeFlag1;

	[FieldOffset(254)]
	[ReferenceTable("QuestFlags")]
	public TableReference DowngradeFlag2;

	[FieldOffset(270)]
	[ReferenceTable("QuestFlags")]
	public TableReference DowngradeFlag3;

}
