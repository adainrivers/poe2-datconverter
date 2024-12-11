using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct LakeRooms
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ElementType(typeof(TString))]
	public TArray ARMFiles;

	[FieldOffset(24)]
	public TString Script;

	[FieldOffset(32)]
	[ElementType(typeof(int))]
	public TArray Unk003;

	[FieldOffset(48)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TRef))]
	public TArray Stats;

	[FieldOffset(64)]
	[ElementType(typeof(int))]
	public TArray StatsValues;

	[FieldOffset(80)]
	public TString Description;

	[FieldOffset(88)]
	public TString Name;

	[FieldOffset(96)]
	public int Type;

	[FieldOffset(100)]
	[ReferenceTable("WorldAreas")]
	public TRef WorldArea;

	[FieldOffset(116)]
	public TString Icon;

	[FieldOffset(124)]
	public int Unk011;

	[FieldOffset(128)]
	public int MinLevel;

	[FieldOffset(132)]
	public TRef Unk013;

	[FieldOffset(148)]
	public TBool Unk014;

	[FieldOffset(149)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TRef))]
	public TArray ExtraStats;

	[FieldOffset(165)]
	[ElementType(typeof(int))]
	public TArray ExtraStatsValues;

	[FieldOffset(181)]
	public TString ReminderText;

	[FieldOffset(189)]
	[ReferenceTable("NPCTextAudio")]
	public TRef TextAudio;

	[FieldOffset(205)]
	public TRef Unk019;

	[FieldOffset(221)]
	public TBool Unk020;

}
