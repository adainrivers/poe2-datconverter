using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HeistNPCs
{
	[FieldOffset(0)]
	[ReferenceTable("NPCs")]
	public TRef NPCsKey;

	[FieldOffset(16)]
	[ReferenceTable("MonsterVarieties")]
	public TRef MonsterVarietiesKey;

	[FieldOffset(32)]
	[ReferenceTable("HeistJobs")]
	[ElementType(typeof(TRef))]
	public TArray SkillLevel_HeistJobsKeys;

	[FieldOffset(48)]
	public TString PortraitFile;

	[FieldOffset(56)]
	[ReferenceTable("HeistNPCStats")]
	[ElementType(typeof(TRef))]
	public TArray HeistNPCStatsKeys;

	[FieldOffset(72)]
	[ElementType(typeof(float))]
	public TArray StatValues;

	[FieldOffset(88)]
	public float Unk006;

	[FieldOffset(92)]
	[ElementType(typeof(int))]
	public TArray SkillLevel_Values;

	[FieldOffset(108)]
	public TString Name;

	[FieldOffset(116)]
	public TString SilhouetteFile;

	[FieldOffset(124)]
	public int Unk010;

	[FieldOffset(128)]
	public int Unk011;

	[FieldOffset(132)]
	[ReferenceTable("HeistNPCs")]
	public TRef HeistNPCsKey;

	[FieldOffset(140)]
	[ElementType(typeof(float))]
	public TArray StatValues2;

	[FieldOffset(156)]
	[ReferenceTable("NPCs")]
	public TRef Ally_NPCsKey;

	[FieldOffset(172)]
	public TString ActiveNPCIcon;

	[FieldOffset(180)]
	[ReferenceTable("HeistJobs")]
	public TRef HeistJobsKey;

	[FieldOffset(196)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TRef))]
	public TArray Equip_AchievementItemsKeys;

	[FieldOffset(212)]
	public TString AOFile;

	[FieldOffset(220)]
	public TRef Unk019;

}
