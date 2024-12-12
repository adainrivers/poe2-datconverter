namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HeistContracts
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference BaseItemTypesKey;

	[FieldOffset(16)]
	[ReferenceTable("HeistAreas")]
	public TableReference HeistAreasKey;

	[FieldOffset(32)]
	public int Unk002;

}
