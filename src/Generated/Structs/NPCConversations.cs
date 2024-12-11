using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct NPCConversations
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("DialogueEvent")]
	public TRef DialogueEvent;

	[FieldOffset(24)]
	[ReferenceTable("NPCTextAudio")]
	[ElementType(typeof(TRef))]
	public TArray NPCTextAudioKeys;

	[FieldOffset(40)]
	[ElementType(typeof(int))]
	public TArray Unk003;

	[FieldOffset(56)]
	public int Unk004;

}
