using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct PassiveSkillMasteryGroups
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("PassiveSkillMasteryEffects")]
	[ElementType(typeof(TRef))]
	public TArray MasteryEffects;

	[FieldOffset(24)]
	public TString InactiveIcon;

	[FieldOffset(32)]
	public TString ActiveIcon;

	[FieldOffset(40)]
	public TString ActiveEffectImage;

	[FieldOffset(48)]
	public bool Unk005;

	[FieldOffset(49)]
	[ReferenceTable("SoundEffects")]
	public TRef SoundEffect;

	[FieldOffset(65)]
	[ReferenceTable("Stats")]
	public TRef MasteryCountStat;

}
