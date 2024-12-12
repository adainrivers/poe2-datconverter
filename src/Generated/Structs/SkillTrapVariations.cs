namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SkillTrapVariations
{
	[FieldOffset(0)]
	public int Id;

	[FieldOffset(4)]
	public StringReference Metadata;

	[FieldOffset(12)]
	[ReferenceTable("MiscAnimated")]
	public TableReference MiscAnimated;

}
