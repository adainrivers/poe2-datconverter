namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SkillGems
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference BaseItemTypesKey;

	[FieldOffset(16)]
	public int StrengthRequirementPercent;

	[FieldOffset(20)]
	public int DexterityRequirementPercent;

	[FieldOffset(24)]
	public int IntelligenceRequirementPercent;

	[FieldOffset(28)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference VaalVariant_BaseItemTypesKey;

	[FieldOffset(44)]
	public TBool IsVaalVariant;

	[FieldOffset(45)]
	[ReferenceTable("Stats")]
	public TableReference MinionGlobalSkillLevelStat;

	[FieldOffset(61)]
	public TBool IsSupport;

	[FieldOffset(62)]
	public TBool Unk008;

	[FieldOffset(63)]
	public TBool Unk063;

	[FieldOffset(64)]
	public TBool Unk064;

	[FieldOffset(65)]
	public TBool Unk065;

	[FieldOffset(66)]
	public TBool Unk066;

	[FieldOffset(67)]
	[ReferenceTable("SkillGems")]
	public TableReference AwakenedVariant;

	[FieldOffset(83)]
	public int Unk083;

    [FieldOffset(87)]
	public int Unk087;

    [FieldOffset(91)]
    public int Unk091;

	[FieldOffset(107)]
	[ElementType(typeof(TableReference))]
    public ArrayReference Unk107;

    [FieldOffset(123)]
    [ElementType(typeof(TableReference))]
    public ArrayReference Unk123;

	[FieldOffset(139)]
	public TBool Unk139;

    [FieldOffset(140)]
    [ElementType(typeof(TableReference))]
	[ReferenceTable("GemEffects")]
    public ArrayReference GemEffects;


    [FieldOffset(156)]
	public TBool Unk156;

    [FieldOffset(157)]
    public StringReference TutorialVideoPath;


    [FieldOffset(165)]
    public StringReference GemHoverImage;

    [FieldOffset(173)]
	public int Column;

    [FieldOffset(177)]
    public TBool Unk177;

    [FieldOffset(178)]
	public int Unk178;

    [FieldOffset(182)]
    public int Unk182;

    [FieldOffset(186)]
	public TBool Unk186;

    [FieldOffset(187)] public StringReference Attribute;





    //[FieldOffset(75)]
    //[ReferenceTable("SkillGems")]
    //public TableReference RegularVariant;

    //[FieldOffset(83)]
    //public int Unk015;

    //[FieldOffset(87)]
    //[ReferenceTable("ItemExperienceTypes")]
    //public TableReference ItemExperienceType;

    //[FieldOffset(103)]
    //[ReferenceTable("MicrotransactionSkillGemEffectSlotTypes")]
    //[ElementType(typeof(TableReference))]
    //public ArrayReference MtxSlotTypes;

    //[FieldOffset(119)]
    //[ReferenceTable("GemEffects")]
    //[ElementType(typeof(TableReference))]
    //public ArrayReference GemEffects;

}
