using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ActiveSkills
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString DisplayedName;

	[FieldOffset(16)]
	public TString Description;

	[FieldOffset(24)]
	[ReferenceTable("ActionTypes")]
	public TRef ActionType;

	[FieldOffset(40)]
	public TString Icon_DDSFile;

	[FieldOffset(48)]
	[ReferenceTable("ActiveSkillTargetTypes")]
	[EnumName("ActiveSkillTargetTypes")]
	[ElementType(typeof(TEnum))]
	public TArray ActiveSkillTargetTypes;

	[FieldOffset(64)]
	[ReferenceTable("ActiveSkillType")]
	[ElementType(typeof(TRef))]
	public TArray ActiveSkillTypes;

	[FieldOffset(80)]
	[ReferenceTable("ItemClasses")]
	[ElementType(typeof(TRef))]
	public TArray WeaponRestriction_ItemClassesKeys;

	[FieldOffset(96)]
	public TString WebsiteDescription;

	[FieldOffset(104)]
	public TString WebsiteImage;

	[FieldOffset(112)]
	public TBool Unk010;

	[FieldOffset(113)]
	public TString Unk011;

	[FieldOffset(121)]
	public TBool Unk012;

	[FieldOffset(122)]
	[ReferenceTable("SkillTotems")]
	[EnumName("SkillTotems")]
	public TEnum SkillTotemId;

	[FieldOffset(126)]
	public TBool IsManuallyCasted;

	[FieldOffset(127)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TRef))]
	public TArray Input_StatKeys;

	[FieldOffset(143)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TRef))]
	public TArray Output_StatKeys;

	[FieldOffset(159)]
	[ReferenceTable("ActiveSkillType")]
	[ElementType(typeof(TRef))]
	public TArray MinionActiveSkillTypes;

	[FieldOffset(175)]
	public TBool Unk018;

	[FieldOffset(176)]
	public TBool Unk019;

	[FieldOffset(177)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TRef))]
	public TArray Unk020;

	[FieldOffset(193)]
	public int Unk021;

	[FieldOffset(197)]
	[ReferenceTable("AlternateSkillTargetingBehaviours")]
	public TRef AlternateSkillTargetingBehavioursKey;

	[FieldOffset(213)]
	public TBool Unk023;

	[FieldOffset(214)]
	public TString AIFile;

	[FieldOffset(222)]
	[ElementType(typeof(TRef))]
	public TArray Unk025;

	[FieldOffset(238)]
	public TBool Unk026;

	[FieldOffset(239)]
	public TBool Unk027;

	[FieldOffset(240)]
	public TBool Unk028;

	[FieldOffset(241)]
	[ReferenceTable("ActiveSkills")]
	public TRef TransfigureBase;

}
