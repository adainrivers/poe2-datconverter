using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SoundEffects
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString SoundFile;

	[FieldOffset(16)]
	public TString SoundFile_2D;

	[FieldOffset(24)]
	public TBool Unk003;

	[FieldOffset(25)]
	public TString Unk004;

}
