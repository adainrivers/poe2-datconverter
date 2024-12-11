using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct GrantedEffectsPerLevel
{
	[FieldOffset(0)]
	[ReferenceTable("GrantedEffects")]
	public TRef GrantedEffect;

	[FieldOffset(16)]
	public int Level;

	[FieldOffset(20)]
	public float PlayerLevelReq;

	[FieldOffset(24)]
	public int CostMultiplier;

	[FieldOffset(28)]
	public int StoredUses;

	[FieldOffset(32)]
	public int Cooldown;

	[FieldOffset(36)]
	[ReferenceTable("CooldownBypassTypes")]
	[EnumName("CooldownBypassTypes")]
	public TEnum CooldownBypassType;

	[FieldOffset(40)]
	public int VaalSouls;

	[FieldOffset(44)]
	public int VaalStoredUses;

	[FieldOffset(48)]
	public int CooldownGroup;

	[FieldOffset(52)]
	public int Unk010;

	[FieldOffset(56)]
	public int SoulGainPreventionDuration;

	[FieldOffset(60)]
	public int AttackSpeedMultiplier;

	[FieldOffset(64)]
	public int Unk013;

	[FieldOffset(68)]
	[ElementType(typeof(int))]
	public TArray CostAmounts;

	[FieldOffset(84)]
	[ReferenceTable("CostTypes")]
	[ElementType(typeof(TRef))]
	public TArray CostTypes;

	[FieldOffset(100)]
	public int ManaReservationFlat;

	[FieldOffset(104)]
	public int ManaReservationPercent;

	[FieldOffset(108)]
	public int LifeReservationFlat;

	[FieldOffset(112)]
	public int LifeReservationPercent;

	[FieldOffset(116)]
	public int AttackTime;

}
