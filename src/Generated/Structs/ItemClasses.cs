using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ItemClasses
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Name;

	[FieldOffset(16)]
	[ReferenceTable("TradeMarketCategory")]
	public TRef TradeMarketCategory;

	[FieldOffset(32)]
	[ReferenceTable("ItemClassCategories")]
	public TRef ItemClassCategory;

	[FieldOffset(48)]
	public TBool RemovedIfLeavesArea;

	[FieldOffset(49)]
	[ElementType(typeof(int))]
	public TArray Unk005;

	[FieldOffset(65)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TRef))]
	public TArray IdentifyAchievements;

	[FieldOffset(81)]
	public TBool AllocateToMapOwner;

	[FieldOffset(82)]
	public TBool AlwaysAllocate;

	[FieldOffset(83)]
	public TBool CanHaveVeiledMods;

	[FieldOffset(84)]
	[ReferenceTable("QuestFlags")]
	public TRef PickedUpQuest;

	[FieldOffset(100)]
	public int Unk011;

	[FieldOffset(104)]
	public TBool AlwaysShow;

	[FieldOffset(105)]
	public TBool CanBeCorrupted;

	[FieldOffset(106)]
	public TBool CanHaveIncubators;

	[FieldOffset(107)]
	public TBool CanHaveInfluence;

	[FieldOffset(108)]
	public TBool CanBeDoubleCorrupted;

	[FieldOffset(109)]
	public TBool CanHaveAspects;

	[FieldOffset(110)]
	public TBool CanTransferSkin;

	[FieldOffset(111)]
	[ReferenceTable("ItemStances")]
	public TRef ItemStance;

	[FieldOffset(127)]
	public TBool CanScourge;

	[FieldOffset(128)]
	public TBool CanUpgradeRarity;

	[FieldOffset(129)]
	public TBool Unk022;

	[FieldOffset(130)]
	public TBool Unk023;

	[FieldOffset(131)]
	[ElementType(typeof(int))]
	public TArray MaxInventoryDimensions;

	[FieldOffset(147)]
	[ReferenceTable("ItemClassFlags")]
	[EnumName("ItemClassFlags")]
	[ElementType(typeof(TEnum))]
	public TArray Flags;

	[FieldOffset(163)]
	public TBool Unmodifiable;

	[FieldOffset(164)]
	public TBool CanBeFractured;

	[FieldOffset(165)]
	[ReferenceTable("AchievementItems")]
	public TRef EquipAchievements;

	//[FieldOffset(181)]
	//public TBool UsedInMapDevice;

	//[FieldOffset(182)]
	//public TBool Unk030;

	//[FieldOffset(183)]
	//public TBool Unk031;

	//[FieldOffset(184)]
	//public TBool Unk032;

}
