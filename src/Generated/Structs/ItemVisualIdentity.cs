using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ItemVisualIdentity
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString DDSFile;

	[FieldOffset(16)]
	public TString AOFile;

	[FieldOffset(24)]
	[ReferenceTable("SoundEffects")]
	public TRef InventorySoundEffect;

	[FieldOffset(40)]
	public short HASH16;

	[FieldOffset(42)]
	public TString AOFile2;

	[FieldOffset(50)]
	[ElementType(typeof(TString))]
	public TArray MarauderSMFiles;

	[FieldOffset(66)]
	[ElementType(typeof(TString))]
	public TArray RangerSMFiles;

	[FieldOffset(82)]
	[ElementType(typeof(TString))]
	public TArray WitchSMFiles;

	[FieldOffset(98)]
	[ElementType(typeof(TString))]
	public TArray DuelistDexSMFiles;

	[FieldOffset(114)]
	[ElementType(typeof(TString))]
	public TArray TemplarSMFiles;

	[FieldOffset(130)]
	[ElementType(typeof(TString))]
	public TArray ShadowSMFiles;

	[FieldOffset(146)]
	[ElementType(typeof(TString))]
	public TArray ScionSMFiles;

	[FieldOffset(162)]
	public TString MarauderShape;

	[FieldOffset(170)]
	public TString RangerShape;

	[FieldOffset(178)]
	public TString WitchShape;

	[FieldOffset(186)]
	public TString DuelistShape;

	[FieldOffset(194)]
	public TString TemplarShape;

	[FieldOffset(202)]
	public TString ShadowShape;

	[FieldOffset(210)]
	public TString ScionShape;

	[FieldOffset(218)]
	public int Unk020;

	[FieldOffset(222)]
	public int Unk021;

	[FieldOffset(226)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TRef))]
	public TArray Pickup_AchievementItemsKeys;

	[FieldOffset(242)]
	[ElementType(typeof(TString))]
	public TArray SMFiles;

	[FieldOffset(258)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TRef))]
	public TArray Identify_AchievementItemsKeys;

	[FieldOffset(274)]
	public TString EPKFile;

	[FieldOffset(282)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TRef))]
	public TArray Corrupt_AchievementItemsKeys;

	[FieldOffset(298)]
	public bool IsAlternateArt;

	[FieldOffset(299)]
	public bool Unk028;

	[FieldOffset(300)]
	[ReferenceTable("AchievementItems")]
	public TRef CreateCorruptedJewelAchievementItemsKey;

	[FieldOffset(316)]
	public TString AnimationLocation;

	[FieldOffset(324)]
	public TString Unk031;

	[FieldOffset(332)]
	public TString Unk032;

	[FieldOffset(340)]
	public TString Unk033;

	[FieldOffset(348)]
	public TString Unk034;

	[FieldOffset(356)]
	public TString Unk035;

	[FieldOffset(364)]
	public TString Unk036;

	[FieldOffset(372)]
	public TString Unk037;

	[FieldOffset(380)]
	public TString Unk038;

	[FieldOffset(388)]
	public TString Unk039;

	[FieldOffset(396)]
	public TString Unk040;

	[FieldOffset(404)]
	public TString Unk041;

	[FieldOffset(412)]
	public TString Unk042;

	[FieldOffset(420)]
	public bool IsAtlasOfWorldsMapIcon;

	[FieldOffset(421)]
	public bool IsTier16Icon;

	[FieldOffset(422)]
	[ElementType(typeof(int))]
	public TArray Unk045;

	[FieldOffset(438)]
	public bool Unk046;

	[FieldOffset(439)]
	[ElementType(typeof(TRef))]
	public TArray Unk047;

	[FieldOffset(455)]
	public TString Unk048;

	[FieldOffset(463)]
	public int Composition;

	[FieldOffset(467)]
	public TRef Unk050;

	[FieldOffset(483)]
	public TRef Unk051;

	[FieldOffset(499)]
	public TRef Unk052;

	[FieldOffset(515)]
	public TRef Unk053;

	[FieldOffset(531)]
	[ElementType(typeof(TRef))]
	public TArray Unk054;

	[FieldOffset(547)]
	[ElementType(typeof(TRef))]
	public TArray Unk055;

	[FieldOffset(563)]
	public bool Unk056;

}
