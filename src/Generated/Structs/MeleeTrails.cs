using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MeleeTrails
{
	[FieldOffset(0)]
	public TString EPKFile1;

	[FieldOffset(8)]
	public int Unk001;

	[FieldOffset(12)]
	public TString EPKFile2;

	[FieldOffset(20)]
	public int Unk003;

	[FieldOffset(24)]
	public int Unk004;

	[FieldOffset(28)]
	public int Unk005;

	[FieldOffset(32)]
	public TBool Unk006;

	[FieldOffset(33)]
	public TString AOFile;

	[FieldOffset(41)]
	public TBool Unk008;

	[FieldOffset(42)]
	public TString Unk009;

}
