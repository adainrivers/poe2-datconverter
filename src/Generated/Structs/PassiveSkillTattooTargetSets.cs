namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct PassiveSkillTattooTargetSets
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ElementType(typeof(int))]
	public ArrayReference Set;

	[FieldOffset(24)]
	public StringReference Name;

	[FieldOffset(32)]
	public StringReference Qualifier;

}
