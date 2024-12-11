using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BaseItemTypes
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("ItemClasses")]
	public TRef ItemClassesKey;

	[FieldOffset(24)]
	public int Width;

	[FieldOffset(28)]
	public int Height;

	[FieldOffset(32)]
	public TString Name;

	[FieldOffset(40)]
	public TString InheritsFrom;

	[FieldOffset(48)]
	public int DropLevel;

	[FieldOffset(52)]
	[ReferenceTable("FlavourText")]
	public TRef FlavourTextKey;

	[FieldOffset(68)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TRef))]
	public TArray Implicit_ModsKeys;

	[FieldOffset(84)]
	public int SizeOnGround;

	[FieldOffset(88)]
	[ReferenceTable("SoundEffects")]
	public TRef SoundEffect;

	[FieldOffset(104)]
	[ReferenceTable("Tags")]
	[ElementType(typeof(TRef))]
	public TArray TagsKeys;

	[FieldOffset(120)]
	[ReferenceTable("ModDomains")]
	[EnumName("ModDomains")]
	public TEnum ModDomain;

	[FieldOffset(124)]
	public int SiteVisibility;

	[FieldOffset(128)]
	[ReferenceTable("ItemVisualIdentity")]
	public TRef ItemVisualIdentity;

	[FieldOffset(144)]
	public int HASH32;

	[FieldOffset(148)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TRef))]
	public TArray VendorRecipe_AchievementItems;

	[FieldOffset(164)]
	public TString Inflection;

	[FieldOffset(172)]
	[ReferenceTable("AchievementItems")]
	public TRef Equip_AchievementItemsKey;

	[FieldOffset(188)]
	public bool IsCorrupted;

	[FieldOffset(189)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TRef))]
	public TArray Identify_AchievementItems;

	[FieldOffset(205)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TRef))]
	public TArray IdentifyMagic_AchievementItems;

	[FieldOffset(221)]
	[ReferenceTable("BaseItemTypes")]
	public TRef FragmentBaseItemTypesKey;

	[FieldOffset(229)]
	public bool Unk023;

	[FieldOffset(230)]
	public TRef Unk024;

	[FieldOffset(246)]
	public TRef Unk025;

	[FieldOffset(262)]
	public bool Unk026;

	[FieldOffset(263)]
	[ReferenceTable("TradeMarketCategory")]
	public TRef TradeMarketCategory;

	[FieldOffset(279)]
	public bool Unmodifiable;

	[FieldOffset(280)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TRef))]
	public TArray Achievement;

	[FieldOffset(296)]
	[ElementType(typeof(TString))]
	public TArray Unk030;

	[FieldOffset(312)]
	public bool IgnoreQuantBonus;

	[FieldOffset(313)]
	public bool Unk032;

}
