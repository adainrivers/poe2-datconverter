using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BetrayalTargetJobAchievements
{
	[FieldOffset(0)]
	[ReferenceTable("BetrayalTargets")]
	public TRef BetrayalTargetsKey;

	[FieldOffset(16)]
	[ReferenceTable("BetrayalJobs")]
	public TRef BetrayalJobsKey;

	[FieldOffset(32)]
	[ReferenceTable("AchievementItems")]
	public TRef AchievementItemsKey;

}
