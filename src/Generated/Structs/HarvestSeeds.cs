using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HarvestSeeds
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("MonsterVarieties")]
	public TRef Monster;

	[FieldOffset(24)]
	public int Tier;

	[FieldOffset(28)]
	public int Unk003;

	[FieldOffset(32)]
	[ElementType(typeof(int))]
	public TArray Unk004;

	[FieldOffset(48)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TRef))]
	public TArray Achievements;

	[FieldOffset(64)]
	public TString SeedAnimation;

	[FieldOffset(72)]
	public int Unk007;

	[FieldOffset(76)]
	public TString HatchAnimation;

	[FieldOffset(84)]
	public int SeedType;

}
