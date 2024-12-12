namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct DelveRooms
{
	[FieldOffset(0)]
	[ReferenceTable("DelveBiomes")]
	public TableReference DelveBiomesKey;

	[FieldOffset(16)]
	[ReferenceTable("DelveFeatures")]
	public TableReference DelveFeaturesKey;

	[FieldOffset(32)]
	public StringReference ARMFile;

}
