namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HellscapePassiveTree
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public int AllocationsRequired;

	[FieldOffset(12)]
	[ReferenceTable("HellscapePassives")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Passives;

}
