using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct PantheonPanelLayout
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public int X;

	[FieldOffset(12)]
	public int Y;

	[FieldOffset(16)]
	public bool IsMajorGod;

	[FieldOffset(17)]
	public TString CoverImage;

	[FieldOffset(25)]
	public TString GodName2;

	[FieldOffset(33)]
	public TString SelectionImage;

	[FieldOffset(41)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TRef))]
	public TArray Effect1_StatsKeys;

	[FieldOffset(57)]
	[ElementType(typeof(int))]
	public TArray Effect1_Values;

	[FieldOffset(73)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TRef))]
	public TArray Effect2_StatsKeys;

	[FieldOffset(89)]
	public TString GodName3;

	[FieldOffset(97)]
	[ElementType(typeof(int))]
	public TArray Effect3_Values;

	[FieldOffset(113)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TRef))]
	public TArray Effect3_StatsKeys;

	[FieldOffset(129)]
	public TString GodName4;

	[FieldOffset(137)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TRef))]
	public TArray Effect4_StatsKeys;

	[FieldOffset(153)]
	[ElementType(typeof(int))]
	public TArray Effect4_Values;

	[FieldOffset(169)]
	public TString GodName1;

	[FieldOffset(177)]
	[ElementType(typeof(int))]
	public TArray Effect2_Values;

	[FieldOffset(193)]
	[ReferenceTable("QuestFlags")]
	public TRef QuestFlag;

	[FieldOffset(209)]
	public bool IsDisabled;

	[FieldOffset(210)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TRef))]
	public TArray AchievementItems;

	[FieldOffset(226)]
	public int LeagueQuestFlag1;

	[FieldOffset(230)]
	public int LeagueQuestFlag2;

	[FieldOffset(234)]
	public int LeagueQuestFlag3;

	[FieldOffset(238)]
	[ReferenceTable("QuestFlags")]
	public TRef DowngradeFlag1;

	[FieldOffset(254)]
	[ReferenceTable("QuestFlags")]
	public TRef DowngradeFlag2;

	[FieldOffset(270)]
	[ReferenceTable("QuestFlags")]
	public TRef DowngradeFlag3;

}
