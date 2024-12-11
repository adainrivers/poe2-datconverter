using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AzmeriFeatureRooms
{
	[FieldOffset(0)]
	public int Unk000;

	[FieldOffset(4)]
	public int Unk001;

	[FieldOffset(8)]
	public TString Unk002;

	[FieldOffset(16)]
	public TString Unk003;

	[FieldOffset(24)]
	[ElementType(typeof(int))]
	public TArray Unk004;

	[FieldOffset(40)]
	public bool Unk005;

}
