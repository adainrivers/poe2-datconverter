using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct PassiveSkillOverrides
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Name;

	[FieldOffset(16)]
	public TString NodeIcon;

	[FieldOffset(24)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TRef))]
	public TArray Stats;

	[FieldOffset(40)]
	[ElementType(typeof(int))]
	public TArray StatValues;

	[FieldOffset(56)]
	public int HASH16;

	[FieldOffset(60)]
	public TString PassiveBG;

	[FieldOffset(68)]
	[ReferenceTable("GrantedEffectsPerLevel")]
	public TRef Effect;

	[FieldOffset(84)]
	[ReferenceTable("PassiveSkillOverrideTypes")]
	public TRef Type;

	[FieldOffset(100)]
	[ReferenceTable("PassiveOverrideLimits")]
	public TRef Limit;

	[FieldOffset(116)]
	public int RequiresAdjacent;

	[FieldOffset(120)]
	public int MaxAdjacent;

	[FieldOffset(124)]
	[ReferenceTable("PassiveSkills")]
	public TRef AllocatedPassiveSkill;

}
