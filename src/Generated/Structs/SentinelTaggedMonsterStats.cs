namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SentinelTaggedMonsterStats
{
	[FieldOffset(0)]
	[ReferenceTable("Stats")]
	public TableReference TaggedStat;

	[FieldOffset(16)]
	[ReferenceTable("Stats")]
	public TableReference Unk001;

	[FieldOffset(32)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk002;

	[FieldOffset(48)]
	public TableReference Unk003;

	[FieldOffset(64)]
	public TableReference Unk004;

}
