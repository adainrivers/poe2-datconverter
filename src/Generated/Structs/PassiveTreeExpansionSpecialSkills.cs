using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct PassiveTreeExpansionSpecialSkills
{
	[FieldOffset(0)]
	[ReferenceTable("PassiveSkills")]
	public TRef PassiveSkillsKey;

	[FieldOffset(16)]
	[ReferenceTable("Stats")]
	public TRef StatsKey;

}
