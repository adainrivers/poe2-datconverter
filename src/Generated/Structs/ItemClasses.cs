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
	public bool RemovedIfLeavesArea;

	[FieldOffset(49)]
	[ElementType(typeof(int))]
	public TArray Unk005;

	[FieldOffset(65)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TRef))]
	public TArray IdentifyAchievements;

	[FieldOffset(81)]
	public bool AllocateToMapOwner;

	[FieldOffset(82)]
	public bool AlwaysAllocate;

	[FieldOffset(83)]
	public bool CanHaveVeiledMods;

	[FieldOffset(84)]
	[ReferenceTable("QuestFlags")]
	public TRef PickedUpQuest;

	[FieldOffset(100)]
	public int Unk011;

	[FieldOffset(104)]
	public bool AlwaysShow;

	[FieldOffset(105)]
	public bool CanBeCorrupted;

	[FieldOffset(106)]
	public bool CanHaveIncubators;

	[FieldOffset(107)]
	public bool CanHaveInfluence;

	[FieldOffset(108)]
	public bool CanBeDoubleCorrupted;

	[FieldOffset(109)]
	public bool CanHaveAspects;

	[FieldOffset(110)]
	public bool CanTransferSkin;

	[FieldOffset(111)]
	[ReferenceTable("ItemStances")]
	public TRef ItemStance;

	[FieldOffset(127)]
	public bool CanScourge;

	[FieldOffset(128)]
	public bool CanUpgradeRarity;

	[FieldOffset(129)]
	public bool Unk022;

	[FieldOffset(130)]
	public bool Unk023;

	[FieldOffset(131)]
	[ElementType(typeof(int))]
	public TArray MaxInventoryDimensions;

	[FieldOffset(147)]
	[ReferenceTable("ItemClassFlags")]
	[EnumName("ItemClassFlags")]
	[ElementType(typeof(TEnum))]
	public TArray Flags;

	[FieldOffset(163)]
	public bool Unmodifiable;

	[FieldOffset(164)]
	public bool CanBeFractured;

	[FieldOffset(165)]
	[ReferenceTable("AchievementItems")]
	public TRef EquipAchievements;

	[FieldOffset(181)]
	public bool UsedInMapDevice;

	[FieldOffset(182)]
	public bool Unk030;

	[FieldOffset(183)]
	public bool Unk031;

	[FieldOffset(184)]
	public bool Unk032;

}
