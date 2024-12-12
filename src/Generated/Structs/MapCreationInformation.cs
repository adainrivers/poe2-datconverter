namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MapCreationInformation
{
	[FieldOffset(0)]
	[ReferenceTable("Maps")]
	public TableReference MapsKey;

	[FieldOffset(16)]
	public int Tier;

}
