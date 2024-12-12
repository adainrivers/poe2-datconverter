namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Chests
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public TBool Unk001;

	[FieldOffset(9)]
	public int Unk002;

	[FieldOffset(13)]
	public StringReference Name;

	[FieldOffset(21)]
	[ElementType(typeof(StringReference))]
	public ArrayReference AOFiles;

	[FieldOffset(37)]
	public TBool Unk005;

	[FieldOffset(38)]
	public TBool Unk006;

	[FieldOffset(39)]
	public int Unk007;

	[FieldOffset(43)]
	public TBool Unk008;

	[FieldOffset(44)]
	public TBool Unk009;

	[FieldOffset(45)]
	public int Unk010;

	[FieldOffset(49)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk011;

	[FieldOffset(65)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference BaseItemTypesKey;

	[FieldOffset(81)]
	public TBool Unk013;

	[FieldOffset(82)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TableReference))]
	public ArrayReference ModsKeys;

	[FieldOffset(98)]
	[ReferenceTable("Tags")]
	[ElementType(typeof(TableReference))]
	public ArrayReference TagsKeys;

	[FieldOffset(114)]
	[ReferenceTable("ChestEffects")]
	public TableReference ChestEffectsKey;

	[FieldOffset(130)]
	public int MinLevel;

	[FieldOffset(134)]
	public StringReference Unk018;

	[FieldOffset(142)]
	public int MaxLevel;

	[FieldOffset(146)]
	[ReferenceTable("AchievementItems")]
	public TableReference Corrupt_AchievementItemsKey;

	[FieldOffset(162)]
	[ReferenceTable("AchievementItems")]
	public TableReference CurrencyUse_AchievementItemsKey;

	[FieldOffset(178)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Encounter_AchievementItemsKeys;

	[FieldOffset(194)]
	public TableReference Unk023;

	[FieldOffset(210)]
	public StringReference InheritsFrom;

	[FieldOffset(218)]
	public TBool Unk025;

	[FieldOffset(219)]
	public TableReference Unk026;

	[FieldOffset(235)]
	[ElementType(typeof(int))]
	public ArrayReference Unk027;

	[FieldOffset(251)]
	public StringReference Unk028;

	[FieldOffset(259)]
	public int Unk029;

	[FieldOffset(263)]
	public int Unk030;

	[FieldOffset(267)]
	public TBool Unk031;

	[FieldOffset(268)]
	public TableReference Unk032;

	[FieldOffset(284)]
	public TableReference Unk033;

	[FieldOffset(300)]
	public TBool Unk034;

	[FieldOffset(301)]
	public TBool Unk035;

	[FieldOffset(302)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk036;

	[FieldOffset(318)]
	public TBool IsHardmode;

	[FieldOffset(319)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TableReference))]
	public ArrayReference StatsHardmode;

	[FieldOffset(335)]
	public TBool Unk039;

}
