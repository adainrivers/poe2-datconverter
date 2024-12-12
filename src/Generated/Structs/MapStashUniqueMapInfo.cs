namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MapStashUniqueMapInfo
{
	[FieldOffset(0)]
	[ReferenceTable("UniqueMaps")]
	public TableReference UniqueMap;

	[FieldOffset(16)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference BaseItem;

}
