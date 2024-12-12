namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HeistNPCStats
{
	[FieldOffset(0)]
	[ReferenceTable("Stats")]
	public TableReference StatsKey;

	[FieldOffset(16)]
	public TBool Unk001;

	[FieldOffset(17)]
	public TBool Unk002;

	[FieldOffset(18)]
	public TBool Unk003;

	[FieldOffset(19)]
	public TBool Unk004;

}
