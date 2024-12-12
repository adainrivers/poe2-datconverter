namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MavenFights
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public int WitnessesRequired;

	[FieldOffset(12)]
	public int AreaLevel;

	[FieldOffset(16)]
	public int Unk003;

	[FieldOffset(20)]
	public int Unk004;

	[FieldOffset(24)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference BaseItemType;

	[FieldOffset(40)]
	public int Unk006;

	[FieldOffset(44)]
	public int MinMapTier;

	[FieldOffset(48)]
	[ReferenceTable("QuestFlags")]
	public TableReference Unk008;

	[FieldOffset(64)]
	public int Unk009;

	[FieldOffset(68)]
	[ReferenceTable("WorldAreas")]
	[ElementType(typeof(TableReference))]
	public ArrayReference WitnessAreas;

	[FieldOffset(84)]
	[ReferenceTable("QuestFlags")]
	public TableReference Unk011;

	[FieldOffset(100)]
	public TBool Unk012;

	[FieldOffset(101)]
	[ElementType(typeof(int))]
	public ArrayReference Unk013;

	[FieldOffset(117)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Achievements1;

	[FieldOffset(133)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Achievements2;

}
