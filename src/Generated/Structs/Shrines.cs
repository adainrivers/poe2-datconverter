namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Shrines
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public int TimeoutInSeconds;

	[FieldOffset(12)]
	public TBool ChargesShared;

	[FieldOffset(13)]
	public TableReference Player_ShrineBuffsKey;

	[FieldOffset(29)]
	public int Unk004;

	[FieldOffset(33)]
	public int Unk005;

	[FieldOffset(37)]
	public TableReference Monster_ShrineBuffsKey;

	[FieldOffset(53)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference SummonMonster_MonsterVarietiesKey;

	[FieldOffset(69)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference SummonPlayer_MonsterVarietiesKey;

	[FieldOffset(85)]
	public int Unk009;

	[FieldOffset(89)]
	public int Unk010;

	[FieldOffset(93)]
	[ReferenceTable("ShrineSounds")]
	public TableReference ShrineSoundsKey;

	[FieldOffset(109)]
	public TBool Unk012;

	[FieldOffset(110)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference AchievementItemsKeys;

	[FieldOffset(126)]
	public TBool IsPVPOnly;

	[FieldOffset(127)]
	public TBool Unk015;

	[FieldOffset(128)]
	public TBool IsLesserShrine;

	[FieldOffset(129)]
	[ReferenceTable("ClientStrings")]
	public TableReference Description;

	[FieldOffset(145)]
	[ReferenceTable("ClientStrings")]
	public TableReference Name;

	[FieldOffset(161)]
	public TBool Unk019;

	[FieldOffset(162)]
	public TableReference Unk020;

	[FieldOffset(178)]
	[ElementType(typeof(int))]
	public ArrayReference Unk021;

}
