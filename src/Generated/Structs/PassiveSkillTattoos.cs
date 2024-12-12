namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct PassiveSkillTattoos
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference Tattoo;

	[FieldOffset(16)]
	[ReferenceTable("PassiveSkillOverrides")]
	public TableReference Override;

	[FieldOffset(32)]
	[ReferenceTable("PassiveSkillTattooTargetSets")]
	public TableReference Set;

	[FieldOffset(48)]
	public int Tribe;

	[FieldOffset(52)]
	[ReferenceTable("PassiveSkillOverrideTypes")]
	public TableReference OverrideType;

}
