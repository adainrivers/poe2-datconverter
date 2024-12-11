using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SynthesisAreas
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public int MinLevel;

	[FieldOffset(12)]
	public int MaxLevel;

	[FieldOffset(16)]
	public int Weight;

	[FieldOffset(20)]
	[ReferenceTable("Topologies")]
	public TRef TopologiesKey;

	[FieldOffset(36)]
	[ReferenceTable("MonsterPacks")]
	[ElementType(typeof(TRef))]
	public TArray MonsterPacksKeys;

	[FieldOffset(52)]
	public TString ArtFile;

	[FieldOffset(60)]
	public TString Name;

	[FieldOffset(68)]
	[ReferenceTable("SynthesisAreaSize")]
	public TRef SynthesisAreaSizeKey;

	[FieldOffset(84)]
	[ReferenceTable("AchievementItems")]
	public TRef AchievementItemsKey;

}
