namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct CostTypes
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("Stats")]
	public TableReference StatsKey;

	[FieldOffset(24)]
	public StringReference FormatText;

	[FieldOffset(32)]
	public int Unk003;

}
