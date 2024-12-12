namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ItemExperiencePerLevel
{
	[FieldOffset(0)]
	[ReferenceTable("ItemExperienceTypes")]
	public TableReference ItemExperienceType;

	[FieldOffset(16)]
	public int ItemCurrentLevel;

	[FieldOffset(20)]
	public int Experience;

}
