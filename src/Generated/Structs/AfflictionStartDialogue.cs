using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AfflictionStartDialogue
{
	[FieldOffset(0)]
	[ReferenceTable("WorldAreas")]
	public TRef WorldAreasKey;

	[FieldOffset(16)]
	[ReferenceTable("NPCTextAudio")]
	public TRef NPCTextAudioKey;

	[FieldOffset(32)]
	[ElementType(typeof(TRef))]
	public TArray Unk002;

}
