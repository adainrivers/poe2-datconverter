using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct CharacterAudioEvents
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("QuestFlags")]
	public TRef Event;

	[FieldOffset(24)]
	public int Unk002;

	[FieldOffset(28)]
	public int Unk003;

	[FieldOffset(32)]
	[ReferenceTable("CharacterTextAudio")]
	[ElementType(typeof(TRef))]
	public TArray Goddess_CharacterTextAudioKeys;

	[FieldOffset(48)]
	[ReferenceTable("CharacterTextAudio")]
	[ElementType(typeof(TRef))]
	public TArray JackTheAxe_CharacterTextAudioKeys;

	[FieldOffset(64)]
	public bool Unk006;

	[FieldOffset(65)]
	public bool Unk007;

}
