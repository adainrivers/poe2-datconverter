using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct IndexableSkillGems
{
	[FieldOffset(0)]
	public int Index;

	[FieldOffset(4)]
	[ReferenceTable("SkillGems")]
	[ElementType(typeof(TRef))]
	public TArray SkillGem1;

	[FieldOffset(20)]
	public TString Name1;

	[FieldOffset(28)]
	[ReferenceTable("SkillGems")]
	[ElementType(typeof(TRef))]
	public TArray SkillGem2;

	[FieldOffset(44)]
	public TString Name2;

	[FieldOffset(52)]
	[ReferenceTable("IndexableSkillGems")]
	public TRef Unk005;

}
