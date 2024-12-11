using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct NecropolisCraftingMods
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public int Unk001;

	[FieldOffset(12)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TRef))]
	public TArray Stats;

	[FieldOffset(28)]
	[ElementType(typeof(int))]
	public TArray StatsValues;

	[FieldOffset(44)]
	[ReferenceTable("NecropolisCraftItemTypes")]
	public TRef CraftingItemType;

	[FieldOffset(60)]
	public int Unk005;

	[FieldOffset(64)]
	public TBool CorpsesNotConsumed;

	[FieldOffset(65)]
	[ReferenceTable("NecropolisCraftItemTypes")]
	[ElementType(typeof(TRef))]
	public TArray CraftingItemTypes;

	[FieldOffset(81)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TRef))]
	public TArray Achievements;

	[FieldOffset(97)]
	public int MatchingMonsters;

}
