namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct CurrencyItems
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference BaseItemTypesKey;

	[FieldOffset(16)]
	public int StackSize;

	[FieldOffset(20)]
	public int CurrencyUseType;

	[FieldOffset(24)]
	public StringReference Action;

	[FieldOffset(32)]
	public StringReference Directions;

	[FieldOffset(40)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference FullStack_BaseItemTypesKey;

	[FieldOffset(56)]
	public StringReference Description;

	[FieldOffset(64)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Usage_AchievementItemsKeys;

	[FieldOffset(80)]
	public TBool Scroll;

	[FieldOffset(81)]
	[ReferenceTable("AchievementItems")]
	public TableReference Possession_AchievementItemsKey;

	[FieldOffset(97)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk010;

	[FieldOffset(113)]
	[ElementType(typeof(int))]
	public ArrayReference Unk011;

	[FieldOffset(129)]
	public int CurrencyTab_StackSize;

	[FieldOffset(133)]
	public StringReference XBoxDirections;

	[FieldOffset(141)]
	public int Unk014;

	[FieldOffset(145)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference ModifyMapsAchievements;

	[FieldOffset(161)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference ModifyContractsAchievements;

	[FieldOffset(177)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference CombineAchievements;

	[FieldOffset(193)]
	public TBool ChangedForHardmode;

	[FieldOffset(194)]
	public StringReference DescriptionHardmode;

	[FieldOffset(202)]
	public TBool IsGold;

	[FieldOffset(203)]
	public TBool Unk021;

}
