namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct RitualSetKillAchievements
{
	[FieldOffset(0)]
	[ReferenceTable("AchievementItems")]
	public TableReference Achievement;

	[FieldOffset(16)]
	[ReferenceTable("MonsterVarieties")]
	[ElementType(typeof(TableReference))]
	public ArrayReference KillBosses;

}
