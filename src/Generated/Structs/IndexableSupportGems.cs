using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct IndexableSupportGems
{
	[FieldOffset(0)]
	public int Index;

	[FieldOffset(4)]
	[ReferenceTable("SkillGems")]
	public TRef SupportGem;

	[FieldOffset(20)]
	public TString Name;

}
