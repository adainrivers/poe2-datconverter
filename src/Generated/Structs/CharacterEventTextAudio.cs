using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct CharacterEventTextAudio
{
	[FieldOffset(0)]
	[ReferenceTable("CharacterAudioEvents")]
	public TRef Event;

	[FieldOffset(16)]
	[ReferenceTable("Characters")]
	public TRef Character;

	[FieldOffset(32)]
	[ReferenceTable("CharacterTextAudio")]
	[ElementType(typeof(TRef))]
	public TArray TextAudio;

}
