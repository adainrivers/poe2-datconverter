using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HeistAreas
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("WorldAreas")]
	[ElementType(typeof(TRef))]
	public TArray WorldAreasKeys;

	[FieldOffset(24)]
	public int Unk002;

	[FieldOffset(28)]
	[ReferenceTable("Environments")]
	public TRef EnvironmentsKey1;

	[FieldOffset(44)]
	[ReferenceTable("Environments")]
	public TRef EnvironmentsKey2;

	[FieldOffset(60)]
	[ReferenceTable("HeistJobs")]
	[ElementType(typeof(TRef))]
	public TArray HeistJobsKeys;

	[FieldOffset(76)]
	[ReferenceTable("BaseItemTypes")]
	public TRef Contract_BaseItemTypesKey;

	[FieldOffset(92)]
	[ReferenceTable("BaseItemTypes")]
	public TRef Blueprint_BaseItemTypesKey;

	[FieldOffset(108)]
	public TString DGRFile;

	[FieldOffset(116)]
	public int Unk009;

	[FieldOffset(120)]
	public int Unk010;

	[FieldOffset(124)]
	public bool Unk011;

	[FieldOffset(125)]
	public bool Unk012;

	[FieldOffset(126)]
	public TString Blueprint_DDSFile;

	[FieldOffset(134)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TRef))]
	public TArray Achievements1;

	[FieldOffset(150)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TRef))]
	public TArray Achievements2;

	[FieldOffset(166)]
	[ReferenceTable("ClientStrings")]
	public TRef Reward;

	[FieldOffset(182)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TRef))]
	public TArray Achievements3;

	[FieldOffset(198)]
	[ReferenceTable("ClientStrings")]
	public TRef RewardHardmode;

}
