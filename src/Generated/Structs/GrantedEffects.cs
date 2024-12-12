namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct GrantedEffects
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public TBool IsSupport;

	[FieldOffset(9)]
	[ReferenceTable("ActiveSkillType")]
	[ElementType(typeof(TableReference))]
	public ArrayReference AllowedActiveSkillTypes;

	[FieldOffset(25)]
	public StringReference SupportGemLetter;

	[FieldOffset(33)]
	[ReferenceTable("Attributes")]
	[EnumName("Attributes")]
	public TEnum Attribute;

	[FieldOffset(37)]
	[ReferenceTable("ActiveSkillType")]
	[ElementType(typeof(TableReference))]
	public ArrayReference AddedActiveSkillTypes;

	[FieldOffset(53)]
	[ReferenceTable("ActiveSkillType")]
	[ElementType(typeof(TableReference))]
	public ArrayReference ExcludedActiveSkillTypes;

	[FieldOffset(69)]
	public TBool SupportsGemsOnly;

	[FieldOffset(70)]
	public int Unk008;

	[FieldOffset(74)]
	[ElementType(typeof(int))]
	public ArrayReference Unk009;

	[FieldOffset(90)]
	public TBool CannotBeSupported;

	[FieldOffset(91)]
	public int Unk011;

	[FieldOffset(95)]
	public int CastTime;

	[FieldOffset(99)]
	[ReferenceTable("ActiveSkills")]
	public TableReference ActiveSkill;

	[FieldOffset(115)]
	public TBool IgnoreMinionTypes;

	[FieldOffset(116)]
	public TBool Unk015;

	[FieldOffset(117)]
	[ReferenceTable("ActiveSkillType")]
	[ElementType(typeof(TableReference))]
	public ArrayReference AddedMinionActiveSkillTypes;

	[FieldOffset(133)]
	[ReferenceTable("Animation")]
	public TableReference Animation;

	[FieldOffset(149)]
	[ReferenceTable("MultiPartAchievements")]
	public TableReference MultiPartAchievement;

	[FieldOffset(165)]
	public TBool Unk019;

	[FieldOffset(166)]
	[ReferenceTable("ItemClasses")]
	[ElementType(typeof(TableReference))]
	public ArrayReference SupportWeaponRestrictions;

	[FieldOffset(182)]
	[ReferenceTable("GrantedEffects")]
	public TableReference RegularVariant;

	[FieldOffset(190)]
	public int Unk022;

	[FieldOffset(194)]
	public int Unk023;

	[FieldOffset(198)]
	public int Unk024;

	[FieldOffset(202)]
	public TBool Unk025;

	[FieldOffset(203)]
	[ReferenceTable("GrantedEffectStatSets")]
	public TableReference StatSet;

	[FieldOffset(219)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk027;

}
