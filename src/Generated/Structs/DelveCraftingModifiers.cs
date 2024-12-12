namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct DelveCraftingModifiers
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference BaseItemTypesKey;

	[FieldOffset(16)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TableReference))]
	public ArrayReference AddedModsKeys;

	[FieldOffset(32)]
	[ReferenceTable("Tags")]
	[ElementType(typeof(TableReference))]
	public ArrayReference NegativeWeight_TagsKeys;

	[FieldOffset(48)]
	[ElementType(typeof(int))]
	public ArrayReference NegativeWeight_Values;

	[FieldOffset(64)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TableReference))]
	public ArrayReference ForcedAddModsKeys;

	[FieldOffset(80)]
	[ReferenceTable("DelveCraftingTags")]
	[ElementType(typeof(TableReference))]
	public ArrayReference ForbiddenDelveCraftingTagsKeys;

	[FieldOffset(96)]
	[ReferenceTable("DelveCraftingTags")]
	[ElementType(typeof(TableReference))]
	public ArrayReference AllowedDelveCraftingTagsKeys;

	[FieldOffset(112)]
	public TBool CanMirrorItem;

	[FieldOffset(113)]
	public int CorruptedEssenceChance;

	[FieldOffset(117)]
	public TBool CanImproveQuality;

	[FieldOffset(118)]
	public TBool HasLuckyRolls;

	[FieldOffset(119)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TableReference))]
	public ArrayReference SellPrice_ModsKeys;

	[FieldOffset(135)]
	public TBool CanRollWhiteSockets;

	[FieldOffset(136)]
	[ReferenceTable("Tags")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Weight_TagsKeys;

	[FieldOffset(152)]
	[ElementType(typeof(int))]
	public ArrayReference Weight_Values;

	[FieldOffset(168)]
	[ReferenceTable("DelveCraftingModifierDescriptions")]
	[ElementType(typeof(TableReference))]
	public ArrayReference DelveCraftingModifierDescriptionsKeys;

	[FieldOffset(184)]
	[ReferenceTable("DelveCraftingModifierDescriptions")]
	[ElementType(typeof(TableReference))]
	public ArrayReference BlockedDelveCraftingModifierDescriptionsKeys;

	[FieldOffset(200)]
	public TBool Unk017;

	[FieldOffset(201)]
	public TBool Unk018;

	[FieldOffset(202)]
	[ElementType(typeof(int))]
	public ArrayReference Unk019;

	[FieldOffset(218)]
	[ElementType(typeof(int))]
	public ArrayReference Unk020;

}
