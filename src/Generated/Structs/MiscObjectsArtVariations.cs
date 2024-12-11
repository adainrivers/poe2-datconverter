using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MiscObjectsArtVariations
{
	[FieldOffset(0)]
	public TString Unk000;

	[FieldOffset(8)]
	[ElementType(typeof(int))]
	public TArray Unk001;

	[FieldOffset(24)]
	public int Unk002;

	[FieldOffset(28)]
	public int Unk003;

	[FieldOffset(32)]
	public TRef Unk004;

}
