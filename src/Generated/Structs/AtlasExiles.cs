namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AtlasExiles
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public int Unk001;

	[FieldOffset(12)]
	[ReferenceTable("Stats")]
	public TableReference InfluencedItemIncrStat;

	[FieldOffset(28)]
	public StringReference MapIcon;

	[FieldOffset(36)]
	public StringReference MapIcon2;

}
