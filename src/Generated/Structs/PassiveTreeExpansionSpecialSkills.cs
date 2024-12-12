namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct PassiveTreeExpansionSpecialSkills
{
	[FieldOffset(0)]
	[ReferenceTable("PassiveSkills")]
	public TableReference PassiveSkillsKey;

	[FieldOffset(16)]
	[ReferenceTable("Stats")]
	public TableReference StatsKey;

}
