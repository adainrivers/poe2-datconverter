using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MapCompletionAchievements
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("MapStatConditions")]
	[ElementType(typeof(TRef))]
	public TArray MapStatConditionsKeys;

	[FieldOffset(24)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TRef))]
	public TArray StatsKeys;

	[FieldOffset(40)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TRef))]
	public TArray AchievementItemsKeys;

	[FieldOffset(56)]
	[ReferenceTable("MapTierAchievements")]
	[ElementType(typeof(TRef))]
	public TArray MapTierAchievementsKeys;

	[FieldOffset(72)]
	public TBool Unk005;

	[FieldOffset(73)]
	[ReferenceTable("WorldAreas")]
	[ElementType(typeof(TRef))]
	public TArray WorldAreasKeys;

	[FieldOffset(89)]
	[ElementType(typeof(int))]
	public TArray Unk007;

}
