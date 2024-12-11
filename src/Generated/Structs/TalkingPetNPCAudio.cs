using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct TalkingPetNPCAudio
{
	[FieldOffset(0)]
	[ReferenceTable("TalkingPetAudioEvents")]
	public TRef Unk000;

	[FieldOffset(16)]
	[ReferenceTable("TalkingPets")]
	public TRef Unk001;

	[FieldOffset(32)]
	[ElementType(typeof(int))]
	public TArray Unk002;

	[FieldOffset(48)]
	public TString Unk003;

	[FieldOffset(56)]
	public bool Unk004;

}
