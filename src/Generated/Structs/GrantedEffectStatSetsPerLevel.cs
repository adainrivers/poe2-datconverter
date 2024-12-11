using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct GrantedEffectStatSetsPerLevel
{
	[FieldOffset(0)]
	[ReferenceTable("GrantedEffectStatSets")]
	public TRef StatSet;

	[FieldOffset(16)]
	public int GemLevel;

	[FieldOffset(20)]
	public float PlayerLevelReq;

	[FieldOffset(24)]
	public int SpellCritChance;

	[FieldOffset(28)]
	public int AttackCritChance;

	[FieldOffset(32)]
	public int BaseMultiplier;

	[FieldOffset(36)]
	public int DamageEffectiveness;

	[FieldOffset(40)]
	[ElementType(typeof(int))]
	public TArray BaseResolvedValues;

	[FieldOffset(56)]
	[ElementType(typeof(int))]
	public TArray AdditionalStatsValues;

	[FieldOffset(72)]
	[ReferenceTable("GrantedEffects")]
	[ElementType(typeof(TRef))]
	public TArray GrantedEffects;

	[FieldOffset(88)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TRef))]
	public TArray AdditionalFlags;

	[FieldOffset(104)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TRef))]
	public TArray FloatStats;

	[FieldOffset(120)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TRef))]
	public TArray InterpolationBases;

	[FieldOffset(136)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TRef))]
	public TArray AdditionalStats;

	[FieldOffset(152)]
	[ReferenceTable("StatInterpolationTypes")]
	[EnumName("StatInterpolationTypes")]
	[ElementType(typeof(TEnum))]
	public TArray StatInterpolations;

	[FieldOffset(168)]
	[ElementType(typeof(float))]
	public TArray FloatStatsValues;

}
