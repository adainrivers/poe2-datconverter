namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ActiveSkills
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference DisplayedName;

	[FieldOffset(16)]
	public StringReference Description;

	[FieldOffset(24)]
	[ReferenceTable("ActionTypes")]
	public TableReference ActionType;

	[FieldOffset(40)]
	public StringReference Icon_DDSFile;

	[FieldOffset(48)]
	[ReferenceTable("ActiveSkillTargetTypes")]
	[EnumName("ActiveSkillTargetTypes")]
	[ElementType(typeof(TEnum))]
	public ArrayReference ActiveSkillTargetTypes;

	[FieldOffset(64)]
	[ReferenceTable("ActiveSkillType")]
	[ElementType(typeof(TableReference))]
	public ArrayReference ActiveSkillTypes;

	[FieldOffset(80)]
	[ReferenceTable("ItemClasses")]
	[ElementType(typeof(TableReference))]
	public ArrayReference WeaponRestriction_ItemClassesKeys;

	[FieldOffset(96)]
	public StringReference WebsiteDescription;

	[FieldOffset(104)]
	public StringReference WebsiteImage;

	[FieldOffset(112)]
	public TBool Unk010;

	[FieldOffset(113)]
	public StringReference Unk011;

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
	[ElementType(typeof(TableReference))]
	public ArrayReference Input_StatKeys;

	[FieldOffset(143)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Output_StatKeys;

	[FieldOffset(159)]
	[ReferenceTable("ActiveSkillType")]
	[ElementType(typeof(TableReference))]
	public ArrayReference MinionActiveSkillTypes;

	[FieldOffset(175)]
	public TBool Unk018;

	[FieldOffset(176)]
	public TBool Unk019;

	[FieldOffset(177)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk020;

	[FieldOffset(193)]
	public int Unk021;

	[FieldOffset(197)]
	[ReferenceTable("AlternateSkillTargetingBehaviours")]
	public TableReference AlternateSkillTargetingBehavioursKey;

	[FieldOffset(213)]
	public TBool Unk023;

	[FieldOffset(214)]
	public StringReference AIFile;

	[FieldOffset(222)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk025;

	[FieldOffset(238)]
	public TBool Unk026;

	[FieldOffset(239)]
	public TBool Unk027;

	[FieldOffset(240)]
	public TBool Unk028;

	[FieldOffset(241)]
	[ReferenceTable("ActiveSkills")]
	public TableReference TransfigureBase;

}
