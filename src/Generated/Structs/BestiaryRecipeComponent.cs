namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BestiaryRecipeComponent
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public int MinLevel;

	[FieldOffset(12)]
	[ReferenceTable("BestiaryFamilies")]
	public TableReference BestiaryFamiliesKey;

	[FieldOffset(28)]
	[ReferenceTable("BestiaryGroups")]
	public TableReference BestiaryGroupsKey;

	[FieldOffset(44)]
	[ReferenceTable("Mods")]
	public TableReference ModsKey;

	[FieldOffset(60)]
	[ReferenceTable("BestiaryCapturableMonsters")]
	public TableReference BestiaryCapturableMonstersKey;

	[FieldOffset(76)]
	[ReferenceTable("Rarity")]
	public TableReference BeastRarity;

	[FieldOffset(92)]
	[ReferenceTable("BestiaryGenus")]
	public TableReference BestiaryGenusKey;

}
