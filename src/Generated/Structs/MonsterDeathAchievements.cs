namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MonsterDeathAchievements
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("MonsterVarieties")]
	[ElementType(typeof(TableReference))]
	public ArrayReference MonsterVarietiesKeys;

	[FieldOffset(24)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference AchievementItemsKeys;

	[FieldOffset(40)]
	public TBool Unk003;

	[FieldOffset(41)]
	[ReferenceTable("PlayerConditions")]
	[ElementType(typeof(TableReference))]
	public ArrayReference PlayerConditionsKeys;

	[FieldOffset(57)]
	[ReferenceTable("MonsterDeathConditions")]
	[ElementType(typeof(TableReference))]
	public ArrayReference MonsterDeathConditionsKeys;

	[FieldOffset(73)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk006;

	[FieldOffset(89)]
	public int Unk007;

	[FieldOffset(93)]
	public int Unk008;

	[FieldOffset(97)]
	public TBool Unk009;

	[FieldOffset(98)]
	public TBool Unk010;

	[FieldOffset(99)]
	[ElementType(typeof(int))]
	public ArrayReference Unk011;

	[FieldOffset(115)]
	[ElementType(typeof(int))]
	public ArrayReference Unk012;

	[FieldOffset(131)]
	[ElementType(typeof(StringReference))]
	public ArrayReference Unk013;

	[FieldOffset(147)]
	[ElementType(typeof(int))]
	public ArrayReference Unk014;

	[FieldOffset(163)]
	public TableReference Unk015;

	[FieldOffset(179)]
	public int Unk016;

	[FieldOffset(183)]
	[ReferenceTable("NearbyMonsterConditions")]
	[ElementType(typeof(TableReference))]
	public ArrayReference NearbyMonsterConditionsKeys;

	[FieldOffset(199)]
	public TBool Unk018;

	[FieldOffset(200)]
	[ReferenceTable("MultiPartAchievementConditions")]
	[ElementType(typeof(TableReference))]
	public ArrayReference MultiPartAchievementConditionsKeys;

	[FieldOffset(216)]
	[ElementType(typeof(int))]
	public ArrayReference Unk020;

	[FieldOffset(232)]
	public TBool Unk021;

	[FieldOffset(233)]
	[ElementType(typeof(int))]
	public ArrayReference Unk022;

	[FieldOffset(249)]
	[ElementType(typeof(int))]
	public ArrayReference Unk023;

	[FieldOffset(265)]
	public TBool Unk024;

}
