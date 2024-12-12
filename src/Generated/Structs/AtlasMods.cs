namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AtlasMods
{
	[FieldOffset(0)]
	[ReferenceTable("Mods")]
	public TableReference ModsKey;

	[FieldOffset(16)]
	public int AtlasModTiers;

}
