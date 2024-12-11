using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct CurrencyItems
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TRef BaseItemTypesKey;

	[FieldOffset(16)]
	public int StackSize;

	[FieldOffset(20)]
	public int CurrencyUseType;

	[FieldOffset(24)]
	public TString Action;

	[FieldOffset(32)]
	public TString Directions;

	[FieldOffset(40)]
	[ReferenceTable("BaseItemTypes")]
	public TRef FullStack_BaseItemTypesKey;

	[FieldOffset(56)]
	public TString Description;

	[FieldOffset(64)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TRef))]
	public TArray Usage_AchievementItemsKeys;

	[FieldOffset(80)]
	public TBool Scroll;

	[FieldOffset(81)]
	[ReferenceTable("AchievementItems")]
	public TRef Possession_AchievementItemsKey;

	[FieldOffset(97)]
	[ElementType(typeof(TRef))]
	public TArray Unk010;

	[FieldOffset(113)]
	[ElementType(typeof(int))]
	public TArray Unk011;

	[FieldOffset(129)]
	public int CurrencyTab_StackSize;

	[FieldOffset(133)]
	public TString XBoxDirections;

	[FieldOffset(141)]
	public int Unk014;

	[FieldOffset(145)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TRef))]
	public TArray ModifyMapsAchievements;

	[FieldOffset(161)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TRef))]
	public TArray ModifyContractsAchievements;

	[FieldOffset(177)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TRef))]
	public TArray CombineAchievements;

	[FieldOffset(193)]
	public TBool ChangedForHardmode;

	[FieldOffset(194)]
	public TString DescriptionHardmode;

	[FieldOffset(202)]
	public TBool IsGold;

	[FieldOffset(203)]
	public TBool Unk021;

}
