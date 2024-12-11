using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BlightCraftingResults
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("Mods")]
	public TRef ModsKey;

	[FieldOffset(24)]
	[ReferenceTable("PassiveSkills")]
	public TRef PassiveSkillsKey;

}
