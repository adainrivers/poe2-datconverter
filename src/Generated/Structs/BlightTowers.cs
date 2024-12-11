using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BlightTowers
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Name;

	[FieldOffset(16)]
	public TString Description;

	[FieldOffset(24)]
	public TString Icon;

	[FieldOffset(32)]
	[ReferenceTable("BlightTowers")]
	[ElementType(typeof(TRef))]
	public TArray NextUpgradeOptions;

	[FieldOffset(48)]
	public int Unk005;

	[FieldOffset(52)]
	public TString Tier;

	[FieldOffset(60)]
	public int Radius;

	[FieldOffset(64)]
	public int Unk008;

	[FieldOffset(68)]
	[ReferenceTable("AchievementItems")]
	public TRef SpendResourceAchievement;

	[FieldOffset(84)]
	[ReferenceTable("Stats")]
	public TRef StatsKey;

	[FieldOffset(100)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TRef))]
	public TArray StatsKeys;

	[FieldOffset(116)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TRef))]
	public TArray StatsKeys2;

	[FieldOffset(132)]
	public TBool Unk013;

}
