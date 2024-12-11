using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct PassiveTreeExpansionSkills
{
	[FieldOffset(0)]
	[ReferenceTable("PassiveSkills")]
	public TRef PassiveSkillsKey;

	[FieldOffset(16)]
	[ReferenceTable("PassiveSkills")]
	public TRef Mastery_PassiveSkillsKey;

	[FieldOffset(32)]
	[ReferenceTable("Tags")]
	public TRef TagsKey;

	[FieldOffset(48)]
	[ReferenceTable("PassiveTreeExpansionJewelSizes")]
	public TRef PassiveTreeExpansionJewelSizesKey;

}
