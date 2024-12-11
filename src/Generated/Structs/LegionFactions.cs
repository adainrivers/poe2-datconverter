using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct LegionFactions
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public int SpawnWeight;

	[FieldOffset(12)]
	[ReferenceTable("LegionBalancePerLevel")]
	public TRef LegionBalancePerLevelKey;

	[FieldOffset(28)]
	public float Unk003;

	[FieldOffset(32)]
	public float Unk004;

	[FieldOffset(36)]
	[ReferenceTable("BuffVisuals")]
	public TRef BuffVisualsKey;

	[FieldOffset(52)]
	[ReferenceTable("MiscAnimated")]
	public TRef MiscAnimatedKey1;

	[FieldOffset(68)]
	[ReferenceTable("MiscAnimated")]
	public TRef MiscAnimatedKey2;

	[FieldOffset(84)]
	[ReferenceTable("MiscAnimated")]
	public TRef MiscAnimatedKey3;

	[FieldOffset(100)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TRef))]
	public TArray AchievementItemsKeys1;

	[FieldOffset(116)]
	[ReferenceTable("MiscAnimated")]
	public TRef MiscAnimatedKey4;

	[FieldOffset(132)]
	[ReferenceTable("MiscAnimated")]
	public TRef MiscAnimatedKey5;

	[FieldOffset(148)]
	public float Unk012;

	[FieldOffset(152)]
	public float Unk013;

	[FieldOffset(156)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TRef))]
	public TArray AchievementItemsKeys2;

	[FieldOffset(172)]
	[ReferenceTable("Stats")]
	public TRef StatsKey;

	[FieldOffset(188)]
	public TString Shard;

	[FieldOffset(196)]
	public TString RewardJewelArt;

}
