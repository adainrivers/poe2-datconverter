using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MonsterDeathAchievements
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("MonsterVarieties")]
	[ElementType(typeof(TRef))]
	public TArray MonsterVarietiesKeys;

	[FieldOffset(24)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TRef))]
	public TArray AchievementItemsKeys;

	[FieldOffset(40)]
	public bool Unk003;

	[FieldOffset(41)]
	[ReferenceTable("PlayerConditions")]
	[ElementType(typeof(TRef))]
	public TArray PlayerConditionsKeys;

	[FieldOffset(57)]
	[ReferenceTable("MonsterDeathConditions")]
	[ElementType(typeof(TRef))]
	public TArray MonsterDeathConditionsKeys;

	[FieldOffset(73)]
	[ElementType(typeof(TRef))]
	public TArray Unk006;

	[FieldOffset(89)]
	public int Unk007;

	[FieldOffset(93)]
	public int Unk008;

	[FieldOffset(97)]
	public bool Unk009;

	[FieldOffset(98)]
	public bool Unk010;

	[FieldOffset(99)]
	[ElementType(typeof(int))]
	public TArray Unk011;

	[FieldOffset(115)]
	[ElementType(typeof(int))]
	public TArray Unk012;

	[FieldOffset(131)]
	[ElementType(typeof(TString))]
	public TArray Unk013;

	[FieldOffset(147)]
	[ElementType(typeof(int))]
	public TArray Unk014;

	[FieldOffset(163)]
	public TRef Unk015;

	[FieldOffset(179)]
	public int Unk016;

	[FieldOffset(183)]
	[ReferenceTable("NearbyMonsterConditions")]
	[ElementType(typeof(TRef))]
	public TArray NearbyMonsterConditionsKeys;

	[FieldOffset(199)]
	public bool Unk018;

	[FieldOffset(200)]
	[ReferenceTable("MultiPartAchievementConditions")]
	[ElementType(typeof(TRef))]
	public TArray MultiPartAchievementConditionsKeys;

	[FieldOffset(216)]
	[ElementType(typeof(int))]
	public TArray Unk020;

	[FieldOffset(232)]
	public bool Unk021;

	[FieldOffset(233)]
	[ElementType(typeof(int))]
	public TArray Unk022;

	[FieldOffset(249)]
	[ElementType(typeof(int))]
	public TArray Unk023;

	[FieldOffset(265)]
	public bool Unk024;

}
