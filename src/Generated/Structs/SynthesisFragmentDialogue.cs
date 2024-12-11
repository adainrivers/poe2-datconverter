using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SynthesisFragmentDialogue
{
	[FieldOffset(0)]
	public TRef Unk000;

	[FieldOffset(16)]
	[ReferenceTable("NPCTextAudio")]
	public TRef NPCTextAudioKey1;

	[FieldOffset(32)]
	[ReferenceTable("NPCTextAudio")]
	public TRef NPCTextAudioKey2;

	[FieldOffset(48)]
	[ReferenceTable("NPCTextAudio")]
	public TRef NPCTextAudioKey3;

	[FieldOffset(64)]
	[ReferenceTable("NPCTextAudio")]
	public TRef NPCTextAudioKey4;

	[FieldOffset(80)]
	[ReferenceTable("NPCTextAudio")]
	public TRef NPCTextAudioKey5;

	[FieldOffset(96)]
	[ReferenceTable("NPCTextAudio")]
	public TRef NPCTextAudioKey6;

}
