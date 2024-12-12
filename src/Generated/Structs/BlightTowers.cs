namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BlightTowers
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference Name;

	[FieldOffset(16)]
	public StringReference Description;

	[FieldOffset(24)]
	public StringReference Icon;

	[FieldOffset(32)]
	[ReferenceTable("BlightTowers")]
	[ElementType(typeof(TableReference))]
	public ArrayReference NextUpgradeOptions;

	[FieldOffset(48)]
	public int Unk005;

	[FieldOffset(52)]
	public StringReference Tier;

	[FieldOffset(60)]
	public int Radius;

	[FieldOffset(64)]
	public int Unk008;

	[FieldOffset(68)]
	[ReferenceTable("AchievementItems")]
	public TableReference SpendResourceAchievement;

	[FieldOffset(84)]
	[ReferenceTable("Stats")]
	public TableReference StatsKey;

	[FieldOffset(100)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TableReference))]
	public ArrayReference StatsKeys;

	[FieldOffset(116)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TableReference))]
	public ArrayReference StatsKeys2;

	[FieldOffset(132)]
	public TBool Unk013;

}
