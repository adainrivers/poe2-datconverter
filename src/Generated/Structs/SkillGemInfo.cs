using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SkillGemInfo
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Description;

	[FieldOffset(16)]
	public TString VideoURL1;

	[FieldOffset(24)]
	[ReferenceTable("SkillGems")]
	public TRef SkillGemsKey;

	[FieldOffset(40)]
	public TString VideoURL2;

	[FieldOffset(48)]
	[ReferenceTable("Characters")]
	[ElementType(typeof(TRef))]
	public TArray CharactersKeys;

}
