namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AttributeRequirements
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference BaseItemTypesKey;

	[FieldOffset(16)]
	public int Strength;

	[FieldOffset(20)]
	public int Intelligence;

	[FieldOffset(24)]
	public int Dexterity;
}
