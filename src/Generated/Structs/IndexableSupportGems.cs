namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct IndexableSupportGems
{
	[FieldOffset(0)]
	public int Index;

	[FieldOffset(4)]
	[ReferenceTable("SkillGems")]
	public TableReference SupportGem;

	[FieldOffset(20)]
	public StringReference Name;

}
