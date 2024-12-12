namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BaseItemTypes
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("ItemClasses")]
	public TableReference ItemClassesKey;

	[FieldOffset(24)]
	public int Width;

	[FieldOffset(28)]
	public int Height;

	[FieldOffset(32)]
	public StringReference Name;

	[FieldOffset(40)]
	public StringReference InheritsFrom;

	[FieldOffset(48)]
	public int DropLevel;

	[FieldOffset(52)]
	[ReferenceTable("FlavourText")]
	public TableReference FlavourTextKey;

	[FieldOffset(68)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Implicit_ModsKeys;

	[FieldOffset(84)]
	public int SizeOnGround;

	[FieldOffset(88)]
	[ReferenceTable("SoundEffects")]
	public TableReference SoundEffect;

	[FieldOffset(104)]
	[ReferenceTable("Tags")]
	[ElementType(typeof(TableReference))]
	public ArrayReference TagsKeys;

	[FieldOffset(120)]
	[ReferenceTable("ModDomains")]
	[EnumName("ModDomains")]
	public TEnum ModDomain;

	[FieldOffset(124)]
	public int SiteVisibility;

	[FieldOffset(128)]
	[ReferenceTable("ItemVisualIdentity")]
	public TableReference ItemVisualIdentity;

	[FieldOffset(144)]
	public int HASH32;

	[FieldOffset(148)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference VendorRecipe_AchievementItems;

	[FieldOffset(164)]
	public StringReference Inflection;

	[FieldOffset(172)]
	[ReferenceTable("AchievementItems")]
	public TableReference Equip_AchievementItemsKey;

	[FieldOffset(188)]
	public TBool IsCorrupted;

	[FieldOffset(189)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Identify_AchievementItems;

	[FieldOffset(205)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference IdentifyMagic_AchievementItems;

	[FieldOffset(221)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference FragmentBaseItemTypesKey;

	[FieldOffset(229)]
	public TBool Unk023;

	[FieldOffset(230)]
	public TableReference Unk024;

	[FieldOffset(246)]
	public TableReference Unk025;

	[FieldOffset(262)]
	public TBool Unk026;

	[FieldOffset(263)]
	[ReferenceTable("TradeMarketCategory")]
	public TableReference TradeMarketCategory;

	[FieldOffset(279)]
	public TBool Unmodifiable;

	[FieldOffset(280)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Achievement;

	[FieldOffset(296)]
	[ElementType(typeof(StringReference))]
	public ArrayReference Unk030;

	[FieldOffset(312)]
	public TBool IgnoreQuantBonus;

	[FieldOffset(313)]
	public TBool Unk032;

}
