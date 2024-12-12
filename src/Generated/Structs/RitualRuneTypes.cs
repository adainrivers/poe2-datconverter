namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct RitualRuneTypes
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("MiscAnimated")]
	public TableReference MiscAnimatedKey1;

	[FieldOffset(24)]
	public int SpawnWeight;

	[FieldOffset(28)]
	public int LevelMin;

	[FieldOffset(32)]
	public int LevelMax;

	[FieldOffset(36)]
	[ReferenceTable("BuffDefinitions")]
	public TableReference BuffDefinitionsKey;

	[FieldOffset(52)]
	[ElementType(typeof(int))]
	public ArrayReference BuffStatValues;

	[FieldOffset(68)]
	[ReferenceTable("RitualSpawnPatterns")]
	[ElementType(typeof(TableReference))]
	public ArrayReference SpawnPatterns;

	[FieldOffset(84)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TableReference))]
	public ArrayReference ModsKey;

	[FieldOffset(100)]
	[ElementType(typeof(int))]
	public ArrayReference Unk009;

	[FieldOffset(116)]
	[ElementType(typeof(int))]
	public ArrayReference Unk010;

	[FieldOffset(132)]
	[ReferenceTable("MiscAnimated")]
	public TableReference MiscAnimatedKey2;

	[FieldOffset(148)]
	[ReferenceTable("Environments")]
	public TableReference EnvironmentsKey;

	[FieldOffset(164)]
	public int Unk013;

	[FieldOffset(168)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Achievements;

	[FieldOffset(184)]
	public StringReference Type;

	[FieldOffset(192)]
	public StringReference Description;

	[FieldOffset(200)]
	[ReferenceTable("DaemonSpawningData")]
	public TableReference DaemonSpawningDataKey;

	[FieldOffset(216)]
	public TBool Unk018;

}
