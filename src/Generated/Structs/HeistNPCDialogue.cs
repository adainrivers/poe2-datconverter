using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HeistNPCDialogue
{
	[FieldOffset(0)]
	[ReferenceTable("DialogueEvent")]
	public TRef DialogueEventKey;

	[FieldOffset(16)]
	[ReferenceTable("HeistNPCs")]
	public TRef HeistNPCsKey;

	[FieldOffset(32)]
	[ReferenceTable("NPCTextAudio")]
	[ElementType(typeof(TRef))]
	public TArray AudioNormal;

	[FieldOffset(48)]
	[ReferenceTable("NPCTextAudio")]
	[ElementType(typeof(TRef))]
	public TArray AudioLoud;

	[FieldOffset(64)]
	public int Unk004;

}
