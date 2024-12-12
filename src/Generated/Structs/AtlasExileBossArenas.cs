namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AtlasExileBossArenas
{
	[FieldOffset(0)]
	[ReferenceTable("AtlasExiles")]
	public TableReference Conqueror;

	[FieldOffset(16)]
	[ReferenceTable("WorldAreas")]
	public TableReference WorldArea;

}
