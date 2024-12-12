namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct LegionFactions
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public int SpawnWeight;

	[FieldOffset(12)]
	[ReferenceTable("LegionBalancePerLevel")]
	public TableReference LegionBalancePerLevelKey;

	[FieldOffset(28)]
	public float Unk003;

	[FieldOffset(32)]
	public float Unk004;

	[FieldOffset(36)]
	[ReferenceTable("BuffVisuals")]
	public TableReference BuffVisualsKey;

	[FieldOffset(52)]
	[ReferenceTable("MiscAnimated")]
	public TableReference MiscAnimatedKey1;

	[FieldOffset(68)]
	[ReferenceTable("MiscAnimated")]
	public TableReference MiscAnimatedKey2;

	[FieldOffset(84)]
	[ReferenceTable("MiscAnimated")]
	public TableReference MiscAnimatedKey3;

	[FieldOffset(100)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference AchievementItemsKeys1;

	[FieldOffset(116)]
	[ReferenceTable("MiscAnimated")]
	public TableReference MiscAnimatedKey4;

	[FieldOffset(132)]
	[ReferenceTable("MiscAnimated")]
	public TableReference MiscAnimatedKey5;

	[FieldOffset(148)]
	public float Unk012;

	[FieldOffset(152)]
	public float Unk013;

	[FieldOffset(156)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference AchievementItemsKeys2;

	[FieldOffset(172)]
	[ReferenceTable("Stats")]
	public TableReference StatsKey;

	[FieldOffset(188)]
	public StringReference Shard;

	[FieldOffset(196)]
	public StringReference RewardJewelArt;

}
