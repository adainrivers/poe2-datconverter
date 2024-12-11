using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Chests
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TBool Unk001;

	[FieldOffset(9)]
	public int Unk002;

	[FieldOffset(13)]
	public TString Name;

	[FieldOffset(21)]
	[ElementType(typeof(TString))]
	public TArray AOFiles;

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
	[ElementType(typeof(TRef))]
	public TArray Unk011;

	[FieldOffset(65)]
	[ReferenceTable("BaseItemTypes")]
	public TRef BaseItemTypesKey;

	[FieldOffset(81)]
	public TBool Unk013;

	[FieldOffset(82)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TRef))]
	public TArray ModsKeys;

	[FieldOffset(98)]
	[ReferenceTable("Tags")]
	[ElementType(typeof(TRef))]
	public TArray TagsKeys;

	[FieldOffset(114)]
	[ReferenceTable("ChestEffects")]
	public TRef ChestEffectsKey;

	[FieldOffset(130)]
	public int MinLevel;

	[FieldOffset(134)]
	public TString Unk018;

	[FieldOffset(142)]
	public int MaxLevel;

	[FieldOffset(146)]
	[ReferenceTable("AchievementItems")]
	public TRef Corrupt_AchievementItemsKey;

	[FieldOffset(162)]
	[ReferenceTable("AchievementItems")]
	public TRef CurrencyUse_AchievementItemsKey;

	[FieldOffset(178)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TRef))]
	public TArray Encounter_AchievementItemsKeys;

	[FieldOffset(194)]
	public TRef Unk023;

	[FieldOffset(210)]
	public TString InheritsFrom;

	[FieldOffset(218)]
	public TBool Unk025;

	[FieldOffset(219)]
	public TRef Unk026;

	[FieldOffset(235)]
	[ElementType(typeof(int))]
	public TArray Unk027;

	[FieldOffset(251)]
	public TString Unk028;

	[FieldOffset(259)]
	public int Unk029;

	[FieldOffset(263)]
	public int Unk030;

	[FieldOffset(267)]
	public TBool Unk031;

	[FieldOffset(268)]
	public TRef Unk032;

	[FieldOffset(284)]
	public TRef Unk033;

	[FieldOffset(300)]
	public TBool Unk034;

	[FieldOffset(301)]
	public TBool Unk035;

	[FieldOffset(302)]
	[ElementType(typeof(TRef))]
	public TArray Unk036;

	[FieldOffset(318)]
	public TBool IsHardmode;

	[FieldOffset(319)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TRef))]
	public TArray StatsHardmode;

	[FieldOffset(335)]
	public TBool Unk039;

}
