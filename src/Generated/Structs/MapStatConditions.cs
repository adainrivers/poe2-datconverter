namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MapStatConditions
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("Stats")]
	public TableReference StatsKey;

	[FieldOffset(24)]
	public TBool Unk002;

	[FieldOffset(25)]
	public int StatMin;

	[FieldOffset(29)]
	public int StatMax;

	[FieldOffset(33)]
	public TBool Unk005;

}
