using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MavenFights
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public int WitnessesRequired;

	[FieldOffset(12)]
	public int AreaLevel;

	[FieldOffset(16)]
	public int Unk003;

	[FieldOffset(20)]
	public int Unk004;

	[FieldOffset(24)]
	[ReferenceTable("BaseItemTypes")]
	public TRef BaseItemType;

	[FieldOffset(40)]
	public int Unk006;

	[FieldOffset(44)]
	public int MinMapTier;

	[FieldOffset(48)]
	[ReferenceTable("QuestFlags")]
	public TRef Unk008;

	[FieldOffset(64)]
	public int Unk009;

	[FieldOffset(68)]
	[ReferenceTable("WorldAreas")]
	[ElementType(typeof(TRef))]
	public TArray WitnessAreas;

	[FieldOffset(84)]
	[ReferenceTable("QuestFlags")]
	public TRef Unk011;

	[FieldOffset(100)]
	public TBool Unk012;

	[FieldOffset(101)]
	[ElementType(typeof(int))]
	public TArray Unk013;

	[FieldOffset(117)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TRef))]
	public TArray Achievements1;

	[FieldOffset(133)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TRef))]
	public TArray Achievements2;

}
