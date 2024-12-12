namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct DescentStarterChest
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("Characters")]
	public TableReference CharactersKey;

	[FieldOffset(24)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference BaseItemTypesKey;

	[FieldOffset(40)]
	public StringReference SocketColours;

	[FieldOffset(48)]
	[ReferenceTable("WorldAreas")]
	public TableReference WorldAreasKey;

}
