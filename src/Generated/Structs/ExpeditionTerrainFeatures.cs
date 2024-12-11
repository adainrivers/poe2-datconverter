using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ExpeditionTerrainFeatures
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("ExtraTerrainFeatures")]
	public TRef ExtraFeature;

	[FieldOffset(24)]
	[ReferenceTable("ExpeditionFactions")]
	public TRef ExpeditionFaction;

	[FieldOffset(40)]
	public int MinLevel;

	[FieldOffset(44)]
	public int MaxLevel;

	[FieldOffset(48)]
	public int Unk005;

	[FieldOffset(52)]
	[ReferenceTable("WorldAreas")]
	public TRef Area;

	[FieldOffset(68)]
	[ReferenceTable("ExpeditionAreas")]
	[ElementType(typeof(TRef))]
	public TArray ExpeditionAreas;

	[FieldOffset(84)]
	public int Unk008;

	[FieldOffset(88)]
	public bool Unk009;

	[FieldOffset(89)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TRef))]
	public TArray UnearthAchievements;

}
