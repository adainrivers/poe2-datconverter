using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct GrantedEffects
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public bool IsSupport;

	[FieldOffset(9)]
	[ReferenceTable("ActiveSkillType")]
	[ElementType(typeof(TRef))]
	public TArray AllowedActiveSkillTypes;

	[FieldOffset(25)]
	public TString SupportGemLetter;

	[FieldOffset(33)]
	[ReferenceTable("Attributes")]
	[EnumName("Attributes")]
	public TEnum Attribute;

	[FieldOffset(37)]
	[ReferenceTable("ActiveSkillType")]
	[ElementType(typeof(TRef))]
	public TArray AddedActiveSkillTypes;

	[FieldOffset(53)]
	[ReferenceTable("ActiveSkillType")]
	[ElementType(typeof(TRef))]
	public TArray ExcludedActiveSkillTypes;

	[FieldOffset(69)]
	public bool SupportsGemsOnly;

	[FieldOffset(70)]
	public int Unk008;

	[FieldOffset(74)]
	[ElementType(typeof(int))]
	public TArray Unk009;

	[FieldOffset(90)]
	public bool CannotBeSupported;

	[FieldOffset(91)]
	public int Unk011;

	[FieldOffset(95)]
	public int CastTime;

	[FieldOffset(99)]
	[ReferenceTable("ActiveSkills")]
	public TRef ActiveSkill;

	[FieldOffset(115)]
	public bool IgnoreMinionTypes;

	[FieldOffset(116)]
	public bool Unk015;

	[FieldOffset(117)]
	[ReferenceTable("ActiveSkillType")]
	[ElementType(typeof(TRef))]
	public TArray AddedMinionActiveSkillTypes;

	[FieldOffset(133)]
	[ReferenceTable("Animation")]
	public TRef Animation;

	[FieldOffset(149)]
	[ReferenceTable("MultiPartAchievements")]
	public TRef MultiPartAchievement;

	[FieldOffset(165)]
	public bool Unk019;

	[FieldOffset(166)]
	[ReferenceTable("ItemClasses")]
	[ElementType(typeof(TRef))]
	public TArray SupportWeaponRestrictions;

	[FieldOffset(182)]
	[ReferenceTable("GrantedEffects")]
	public TRef RegularVariant;

	[FieldOffset(190)]
	public int Unk022;

	[FieldOffset(194)]
	public int Unk023;

	[FieldOffset(198)]
	public int Unk024;

	[FieldOffset(202)]
	public bool Unk025;

	[FieldOffset(203)]
	[ReferenceTable("GrantedEffectStatSets")]
	public TRef StatSet;

	[FieldOffset(219)]
	[ElementType(typeof(TRef))]
	public TArray Unk027;

}
