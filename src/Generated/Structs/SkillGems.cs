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
	public TBool Unk009;

	[FieldOffset(64)]
	public TBool Unk010;

	[FieldOffset(65)]
	public TBool Unk011;

	[FieldOffset(66)]
	public TBool Unk012;

	[FieldOffset(67)]
	[ReferenceTable("SkillGems")]
	public TableReference AwakenedVariant;

	[FieldOffset(75)]
	[ReferenceTable("SkillGems")]
	public TableReference RegularVariant;

	[FieldOffset(83)]
	public int Unk015;

	[FieldOffset(87)]
	[ReferenceTable("ItemExperienceTypes")]
	public TableReference ItemExperienceType;

	[FieldOffset(103)]
	[ReferenceTable("MicrotransactionSkillGemEffectSlotTypes")]
	[ElementType(typeof(TableReference))]
	public ArrayReference MtxSlotTypes;

	[FieldOffset(119)]
	[ReferenceTable("GemEffects")]
	[ElementType(typeof(TableReference))]
	public ArrayReference GemEffects;

}
