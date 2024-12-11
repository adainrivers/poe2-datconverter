using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct GeometryChannel
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TRef Unk001;

	[FieldOffset(24)]
	public TRef Unk002;

	[FieldOffset(40)]
	public TRef Unk003;

	[FieldOffset(56)]
	public TString Unk004;

	[FieldOffset(64)]
	public TString Unk005;

	[FieldOffset(72)]
	public TString Unk006;

	[FieldOffset(80)]
	public bool Unk007;

	[FieldOffset(81)]
	public bool Unk008;

	[FieldOffset(82)]
	public TRef Unk009;

	[FieldOffset(98)]
	public TRef Unk010;

	[FieldOffset(114)]
	public TString EPKFile;

	[FieldOffset(122)]
	public int Unk012;

	[FieldOffset(126)]
	public int Unk013;

}
