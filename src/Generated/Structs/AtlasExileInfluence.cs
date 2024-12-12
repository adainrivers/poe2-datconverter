namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AtlasExileInfluence
{
	[FieldOffset(0)]
	[ReferenceTable("AtlasExiles")]
	public TableReference Conqueror;

	[FieldOffset(16)]
	[ReferenceTable("AtlasInfluenceSets")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Sets;

}
