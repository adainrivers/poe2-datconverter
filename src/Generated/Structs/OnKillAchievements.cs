namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct OnKillAchievements
{
	[FieldOffset(0)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference MonsterVarietiesKey;

	[FieldOffset(16)]
	[ReferenceTable("GameStats")]
	public TableReference GameStat;

}
