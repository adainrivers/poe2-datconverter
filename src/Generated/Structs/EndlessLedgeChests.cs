namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct EndlessLedgeChests
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("WorldAreas")]
	public TableReference WorldAreasKey;

	[FieldOffset(24)]
	[ReferenceTable("BaseItemTypes")]
	[ElementType(typeof(TableReference))]
	public ArrayReference BaseItemTypesKeys;

	[FieldOffset(40)]
	public StringReference SocketColour;

}
