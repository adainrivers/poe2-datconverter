namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct InfluenceExalts
{
	[FieldOffset(0)]
	[ReferenceTable("InfluenceTypes")]
	[EnumName("InfluenceTypes")]
	public TEnum Influence;

	[FieldOffset(4)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference BaseItemTypesKey;

}
