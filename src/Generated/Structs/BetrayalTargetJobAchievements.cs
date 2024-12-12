namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BetrayalTargetJobAchievements
{
	[FieldOffset(0)]
	[ReferenceTable("BetrayalTargets")]
	public TableReference BetrayalTargetsKey;

	[FieldOffset(16)]
	[ReferenceTable("BetrayalJobs")]
	public TableReference BetrayalJobsKey;

	[FieldOffset(32)]
	[ReferenceTable("AchievementItems")]
	public TableReference AchievementItemsKey;

}
