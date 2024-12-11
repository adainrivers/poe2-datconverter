using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct NPCTextAudio
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("Characters")]
	[ElementType(typeof(TRef))]
	public TArray Characters;

	[FieldOffset(24)]
	public TString Text;

	[FieldOffset(32)]
	public TString Mono_AudioFile;

	[FieldOffset(40)]
	public TString Stereo_AudioFile;

	[FieldOffset(48)]
	public bool HasStereo;

	[FieldOffset(49)]
	public bool Unk006;

	[FieldOffset(50)]
	public TString Video;

	[FieldOffset(58)]
	public int Unk008;

	[FieldOffset(62)]
	public int Unk009;

	[FieldOffset(66)]
	public int Unk010;

	[FieldOffset(70)]
	[ReferenceTable("NPCs")]
	[ElementType(typeof(TRef))]
	public TArray NPCs;

	[FieldOffset(86)]
	public TRef Unk012;

}
