using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Archetypes
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("Characters")]
	public TRef CharactersKey;

	[FieldOffset(24)]
	public TString PassiveSkillTreeURL;

	[FieldOffset(32)]
	public TString AscendancyClassName;

	[FieldOffset(40)]
	public TString Description;

	[FieldOffset(48)]
	public TString UIImageFile;

	[FieldOffset(56)]
	public TString TutorialVideo_BKFile;

	[FieldOffset(64)]
	public int Unk007;

	[FieldOffset(68)]
	public float Unk008;

	[FieldOffset(72)]
	public float Unk009;

	[FieldOffset(76)]
	public TString BackgroundImageFile;

	[FieldOffset(84)]
	public bool IsTemporary;

	[FieldOffset(85)]
	public bool Unk012;

	[FieldOffset(86)]
	public TString ArchetypeImage;

	[FieldOffset(94)]
	public bool Unk014;

	[FieldOffset(95)]
	public bool Unk015;

}
