using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct TalkingPetAudioEvents
{
	[FieldOffset(0)]
	public TString Event;

	[FieldOffset(8)]
	public int Unk001;

	[FieldOffset(12)]
	public int Unk002;

	[FieldOffset(16)]
	public int Unk003;

	[FieldOffset(20)]
	[ElementType(typeof(int))]
	public TArray Unk004;

	[FieldOffset(36)]
	[ElementType(typeof(int))]
	public TArray Unk005;

	[FieldOffset(52)]
	public int Unk006;

}
