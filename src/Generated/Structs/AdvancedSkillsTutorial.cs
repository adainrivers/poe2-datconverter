using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AdvancedSkillsTutorial
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("SkillGemInfo")]
	[ElementType(typeof(TRef))]
	public TArray SkillGemInfoKey1;

	[FieldOffset(24)]
	[ReferenceTable("SkillGemInfo")]
	[ElementType(typeof(TRef))]
	public TArray SkillGemInfoKey2;

	[FieldOffset(40)]
	public TString Description;

	[FieldOffset(48)]
	public TString International_BK2File;

	[FieldOffset(56)]
	[ReferenceTable("SkillGems")]
	public TRef SkillGemsKey;

	[FieldOffset(72)]
	public TString China_BK2File;

	[FieldOffset(80)]
	[ReferenceTable("Characters")]
	[ElementType(typeof(TRef))]
	public TArray CharactersKey;

}
