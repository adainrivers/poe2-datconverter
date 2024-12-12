namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct LegionRanks
{
	[FieldOffset(0)]
	public int Unk000;

	[FieldOffset(4)]
	public int Unk001;

	[FieldOffset(8)]
	public int Unk002;

	[FieldOffset(12)]
	public int Unk003;

	[FieldOffset(16)]
	public int Unk004;

	[FieldOffset(20)]
	[ReferenceTable("LegionBalancePerLevel")]
	public TableReference LegionBalancePerLevelKey;

	[FieldOffset(36)]
	public int Unk006;

	[FieldOffset(40)]
	public int Unk007;

	[FieldOffset(44)]
	public int Unk008;

}
