namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct DivinationCardArt
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference BaseItemTypesKey;

	[FieldOffset(16)]
	public StringReference VirtualFile;

	[FieldOffset(24)]
	[ReferenceTable("InfluenceTypes")]
	[EnumName("InfluenceTypes")]
	[ElementType(typeof(TEnum))]
	public ArrayReference Influences;

}
