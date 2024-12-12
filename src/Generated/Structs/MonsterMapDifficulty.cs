namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MonsterMapDifficulty
{
	[FieldOffset(0)]
	public int MapLevel;

	[FieldOffset(4)]
	public int Stat1Value;

	[FieldOffset(8)]
	public int Stat2Value;

	[FieldOffset(12)]
	[ReferenceTable("Stats")]
	public TableReference StatsKey1;

	[FieldOffset(28)]
	[ReferenceTable("Stats")]
	public TableReference StatsKey2;

	[FieldOffset(44)]
	[ReferenceTable("Stats")]
	public TableReference StatsKey3;

	[FieldOffset(60)]
	public int Stat3Value;

	[FieldOffset(64)]
	[ReferenceTable("Stats")]
	public TableReference StatsKey4;

	[FieldOffset(80)]
	public int Stat4Value;

}
