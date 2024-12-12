namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct LegionMonsterCounts
{
	[FieldOffset(0)]
	[ReferenceTable("LegionFactions")]
	public TableReference LegionFactionsKey;

	[FieldOffset(16)]
	[ReferenceTable("LegionRanks")]
	public TableReference LegionRanksKey;

	[FieldOffset(32)]
	public int Unk002;

	[FieldOffset(36)]
	public int Unk003;

	[FieldOffset(40)]
	public int Unk004;

	[FieldOffset(44)]
	public int Unk005;

	[FieldOffset(48)]
	public int Unk006;

	[FieldOffset(52)]
	public int Unk007;

}
