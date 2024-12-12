namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AtlasInfluenceOutcomes
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public int Unk001;

	[FieldOffset(12)]
	[ReferenceTable("AtlasInfluenceOutcomeTypes")]
	[EnumName("AtlasInfluenceOutcomeTypes")]
	public TEnum Type;

}
