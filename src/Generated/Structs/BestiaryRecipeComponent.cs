using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BestiaryRecipeComponent
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public int MinLevel;

	[FieldOffset(12)]
	[ReferenceTable("BestiaryFamilies")]
	public TRef BestiaryFamiliesKey;

	[FieldOffset(28)]
	[ReferenceTable("BestiaryGroups")]
	public TRef BestiaryGroupsKey;

	[FieldOffset(44)]
	[ReferenceTable("Mods")]
	public TRef ModsKey;

	[FieldOffset(60)]
	[ReferenceTable("BestiaryCapturableMonsters")]
	public TRef BestiaryCapturableMonstersKey;

	[FieldOffset(76)]
	[ReferenceTable("Rarity")]
	public TRef BeastRarity;

	[FieldOffset(92)]
	[ReferenceTable("BestiaryGenus")]
	public TRef BestiaryGenusKey;

}
