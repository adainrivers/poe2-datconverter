namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct KillstreakThresholds
{
	[FieldOffset(0)]
	public int Kills;

	[FieldOffset(4)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference MonsterVarietiesKey;

	[FieldOffset(20)]
	[ReferenceTable("AchievementItems")]
	public TableReference AchievementItemsKey;

}
