namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BlightCraftingResults
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("Mods")]
	public TableReference ModsKey;

	[FieldOffset(24)]
	[ReferenceTable("PassiveSkills")]
	public TableReference PassiveSkillsKey;

}
