namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct PassiveTreeExpansionSkills
{
	[FieldOffset(0)]
	[ReferenceTable("PassiveSkills")]
	public TableReference PassiveSkillsKey;

	[FieldOffset(16)]
	[ReferenceTable("PassiveSkills")]
	public TableReference Mastery_PassiveSkillsKey;

	[FieldOffset(32)]
	[ReferenceTable("Tags")]
	public TableReference TagsKey;

	[FieldOffset(48)]
	[ReferenceTable("PassiveTreeExpansionJewelSizes")]
	public TableReference PassiveTreeExpansionJewelSizesKey;

}
