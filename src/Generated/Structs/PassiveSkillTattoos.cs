using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct PassiveSkillTattoos
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TRef Tattoo;

	[FieldOffset(16)]
	[ReferenceTable("PassiveSkillOverrides")]
	public TRef Override;

	[FieldOffset(32)]
	[ReferenceTable("PassiveSkillTattooTargetSets")]
	public TRef Set;

	[FieldOffset(48)]
	public int Tribe;

	[FieldOffset(52)]
	[ReferenceTable("PassiveSkillOverrideTypes")]
	public TRef OverrideType;

}
