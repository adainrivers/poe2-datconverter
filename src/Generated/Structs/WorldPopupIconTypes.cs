using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct WorldPopupIconTypes
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Unk001;

	[FieldOffset(16)]
	public int Unk002;

	[FieldOffset(20)]
	public int Unk003;

	[FieldOffset(24)]
	public TBool Unk004;

	[FieldOffset(25)]
	public float Unk005;

	[FieldOffset(29)]
	public float Unk006;

	[FieldOffset(33)]
	public float Unk007;

	[FieldOffset(37)]
	public TString Unk008;

}
