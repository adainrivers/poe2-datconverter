using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct DelveCraftingModifiers
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TRef BaseItemTypesKey;

	[FieldOffset(16)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TRef))]
	public TArray AddedModsKeys;

	[FieldOffset(32)]
	[ReferenceTable("Tags")]
	[ElementType(typeof(TRef))]
	public TArray NegativeWeight_TagsKeys;

	[FieldOffset(48)]
	[ElementType(typeof(int))]
	public TArray NegativeWeight_Values;

	[FieldOffset(64)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TRef))]
	public TArray ForcedAddModsKeys;

	[FieldOffset(80)]
	[ReferenceTable("DelveCraftingTags")]
	[ElementType(typeof(TRef))]
	public TArray ForbiddenDelveCraftingTagsKeys;

	[FieldOffset(96)]
	[ReferenceTable("DelveCraftingTags")]
	[ElementType(typeof(TRef))]
	public TArray AllowedDelveCraftingTagsKeys;

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
	[ElementType(typeof(TRef))]
	public TArray SellPrice_ModsKeys;

	[FieldOffset(135)]
	public TBool CanRollWhiteSockets;

	[FieldOffset(136)]
	[ReferenceTable("Tags")]
	[ElementType(typeof(TRef))]
	public TArray Weight_TagsKeys;

	[FieldOffset(152)]
	[ElementType(typeof(int))]
	public TArray Weight_Values;

	[FieldOffset(168)]
	[ReferenceTable("DelveCraftingModifierDescriptions")]
	[ElementType(typeof(TRef))]
	public TArray DelveCraftingModifierDescriptionsKeys;

	[FieldOffset(184)]
	[ReferenceTable("DelveCraftingModifierDescriptions")]
	[ElementType(typeof(TRef))]
	public TArray BlockedDelveCraftingModifierDescriptionsKeys;

	[FieldOffset(200)]
	public TBool Unk017;

	[FieldOffset(201)]
	public TBool Unk018;

	[FieldOffset(202)]
	[ElementType(typeof(int))]
	public TArray Unk019;

	[FieldOffset(218)]
	[ElementType(typeof(int))]
	public TArray Unk020;

}
