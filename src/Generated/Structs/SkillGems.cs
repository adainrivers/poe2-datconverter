using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SkillGems
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TRef BaseItemTypesKey;

	[FieldOffset(16)]
	public int StrengthRequirementPercent;

	[FieldOffset(20)]
	public int DexterityRequirementPercent;

	[FieldOffset(24)]
	public int IntelligenceRequirementPercent;

	[FieldOffset(28)]
	[ReferenceTable("BaseItemTypes")]
	public TRef VaalVariant_BaseItemTypesKey;

	[FieldOffset(44)]
	public bool IsVaalVariant;

	[FieldOffset(45)]
	[ReferenceTable("Stats")]
	public TRef MinionGlobalSkillLevelStat;

	[FieldOffset(61)]
	public bool IsSupport;

	[FieldOffset(62)]
	public bool Unk008;

	[FieldOffset(63)]
	public bool Unk009;

	[FieldOffset(64)]
	public bool Unk010;

	[FieldOffset(65)]
	public bool Unk011;

	[FieldOffset(66)]
	public bool Unk012;

	[FieldOffset(67)]
	[ReferenceTable("SkillGems")]
	public TRef AwakenedVariant;

	[FieldOffset(75)]
	[ReferenceTable("SkillGems")]
	public TRef RegularVariant;

	[FieldOffset(83)]
	public int Unk015;

	[FieldOffset(87)]
	[ReferenceTable("ItemExperienceTypes")]
	public TRef ItemExperienceType;

	[FieldOffset(103)]
	[ReferenceTable("MicrotransactionSkillGemEffectSlotTypes")]
	[ElementType(typeof(TRef))]
	public TArray MtxSlotTypes;

	[FieldOffset(119)]
	[ReferenceTable("GemEffects")]
	[ElementType(typeof(TRef))]
	public TArray GemEffects;

}
