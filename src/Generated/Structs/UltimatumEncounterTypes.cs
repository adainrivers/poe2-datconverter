using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct UltimatumEncounterTypes
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Name;

	[FieldOffset(16)]
	public TString ProgressBarText;

	[FieldOffset(24)]
	public bool Unk003;

	[FieldOffset(25)]
	public bool Unk004;

	[FieldOffset(26)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TRef))]
	public TArray NormalAchievements;

	[FieldOffset(42)]
	[ReferenceTable("AchievementItems")]
	public TRef InscribedAchievement;

	[FieldOffset(58)]
	public TRef Unk007;

}
