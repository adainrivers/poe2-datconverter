namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HeistJobsExperiencePerLevel
{
	[FieldOffset(0)]
	[ReferenceTable("HeistJobs")]
	public TableReference HeistJobsKey;

	[FieldOffset(16)]
	public int Tier;

	[FieldOffset(20)]
	public int Experience;

	[FieldOffset(24)]
	public int MinLevel;

	[FieldOffset(28)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference AchievementItemsKey;

}
