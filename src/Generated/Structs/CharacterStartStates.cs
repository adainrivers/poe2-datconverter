using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct CharacterStartStates
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Description;

	[FieldOffset(16)]
	[ReferenceTable("Characters")]
	public TRef CharactersKey;

	[FieldOffset(32)]
	public int Level;

	[FieldOffset(36)]
	[ReferenceTable("PassiveSkills")]
	[ElementType(typeof(TRef))]
	public TArray PassiveSkillsKeys;

	[FieldOffset(52)]
	[ReferenceTable("CharacterStartStateSet")]
	public TRef CharacterStartStateSetKey;

	[FieldOffset(68)]
	public TRef Unk006;

	[FieldOffset(84)]
	[ReferenceTable("CharacterStartQuestState")]
	[ElementType(typeof(TRef))]
	public TArray CharacterStartQuestStateKeys;

	[FieldOffset(100)]
	public TBool Unk008;

	[FieldOffset(101)]
	public TString InfoText;

	[FieldOffset(109)]
	public TRef Unk010;

}
