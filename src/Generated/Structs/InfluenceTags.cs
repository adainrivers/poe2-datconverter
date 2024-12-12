namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct InfluenceTags
{
	[FieldOffset(0)]
	[ReferenceTable("ItemClasses")]
	public TableReference ItemClass;

	[FieldOffset(16)]
	[ReferenceTable("InfluenceTypes")]
	[EnumName("InfluenceTypes")]
	public TEnum Influence;

	[FieldOffset(20)]
	[ReferenceTable("Tags")]
	public TableReference Tag;

}
