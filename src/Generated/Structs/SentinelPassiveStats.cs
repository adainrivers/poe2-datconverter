namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SentinelPassiveStats
{
	[FieldOffset(0)]
	[ReferenceTable("Stats")]
	public TableReference Unk000;

	[FieldOffset(16)]
	[ReferenceTable("Stats")]
	public TableReference Unk001;

	[FieldOffset(32)]
	public int Unk002;

}
