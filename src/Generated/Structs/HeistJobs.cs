using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HeistJobs
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Name;

	[FieldOffset(16)]
	public TString RequiredSkillIcon;

	[FieldOffset(24)]
	public TString SkillIcon;

	[FieldOffset(32)]
	public float Unk004;

	[FieldOffset(36)]
	public int Unk005;

	[FieldOffset(40)]
	public TString MapIcon;

	[FieldOffset(48)]
	[ReferenceTable("Stats")]
	public TRef Level_StatsKey;

	[FieldOffset(64)]
	[ReferenceTable("Stats")]
	public TRef Alert_StatsKey;

	[FieldOffset(80)]
	[ReferenceTable("Stats")]
	public TRef Alarm_StatsKey;

	[FieldOffset(96)]
	[ReferenceTable("Stats")]
	public TRef Cost_StatsKey;

	[FieldOffset(112)]
	[ReferenceTable("Stats")]
	public TRef ExperienceGain_StatsKey;

	[FieldOffset(128)]
	public TString ConsoleBlueprintLegend;

	[FieldOffset(136)]
	public TString Description;

}
