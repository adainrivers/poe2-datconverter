using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MavenDialog
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("NPCTextAudio")]
	public TRef TextAudioT1;

	[FieldOffset(24)]
	[ReferenceTable("NPCTextAudio")]
	public TRef TextAudioT2;

	[FieldOffset(40)]
	[ReferenceTable("NPCTextAudio")]
	public TRef TextAudioT3;

	[FieldOffset(56)]
	[ReferenceTable("NPCTextAudio")]
	public TRef TextAudioT4;

	[FieldOffset(72)]
	[ReferenceTable("NPCTextAudio")]
	public TRef TextAudioT5;

	[FieldOffset(88)]
	public bool Unk006;

	[FieldOffset(89)]
	[ReferenceTable("NPCTextAudio")]
	public TRef TextAudioT6;

}
