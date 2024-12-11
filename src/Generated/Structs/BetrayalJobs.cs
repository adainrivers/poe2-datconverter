using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BetrayalJobs
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Text;

	[FieldOffset(16)]
	[ReferenceTable("ExtraTerrainFeatures")]
	public TRef ExtraTerrainFeaturesKey;

	[FieldOffset(32)]
	public TString Art;

	[FieldOffset(40)]
	public int Unk004;

	[FieldOffset(44)]
	public int Unk005;

	[FieldOffset(48)]
	[ReferenceTable("WorldAreas")]
	public TRef WorldAreasKey;

	[FieldOffset(64)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TRef))]
	public TArray Completion_AchievementItemsKey;

	[FieldOffset(80)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TRef))]
	public TArray OpenChests_AchievementItemsKey;

	[FieldOffset(96)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TRef))]
	public TArray MissionCompletion_AcheivementItemsKey;

}
