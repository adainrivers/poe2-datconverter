namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AtlasInfluenceSets
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("AtlasInfluenceOutcomes")]
	[ElementType(typeof(TableReference))]
	public ArrayReference InfluencePacks;

}
