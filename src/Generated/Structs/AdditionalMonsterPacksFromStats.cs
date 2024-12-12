namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AdditionalMonsterPacksFromStats
{
	[FieldOffset(0)]
	[ReferenceTable("Stats")]
	public TableReference StatsKey;

	[FieldOffset(16)]
	public int Unk001;

	[FieldOffset(20)]
	[ReferenceTable("MonsterPacks")]
	[ElementType(typeof(TableReference))]
	public ArrayReference MonsterPacksKeys;

	[FieldOffset(36)]
	public int AdditionalMonsterPacksStatMode;

	[FieldOffset(40)]
	[ReferenceTable("Stats")]
	public TableReference PackCountStatsKey;

	[FieldOffset(56)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TableReference))]
	public ArrayReference StatsKeys;

	[FieldOffset(72)]
	[ElementType(typeof(int))]
	public ArrayReference StatsValues;

	[FieldOffset(88)]
	public int Unk007;

	[FieldOffset(92)]
	[ReferenceTable("Stats")]
	public TableReference PackSizeStatsKey;

}
