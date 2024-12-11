using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct PassiveSkillTreeTutorial
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("Characters")]
	public TRef CharactersKey;

	[FieldOffset(24)]
	public TRef Unk002;

	[FieldOffset(40)]
	public TString ChoiceA_Description;

	[FieldOffset(48)]
	public TString ChoiceB_Description;

	[FieldOffset(56)]
	public TRef Unk005;

	[FieldOffset(72)]
	public TString ChoiceA_PassiveTreeURL;

	[FieldOffset(80)]
	public TString ChoiceB_PassiveTreeURL;

	[FieldOffset(88)]
	public TRef Unk008;

	[FieldOffset(104)]
	public TRef Unk009;

}
