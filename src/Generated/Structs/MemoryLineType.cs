using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MemoryLineType
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TRef Unk001;

	[FieldOffset(24)]
	public int Unk002;

	[FieldOffset(28)]
	[ElementType(typeof(int))]
	public TArray Unk003;

	[FieldOffset(44)]
	[ElementType(typeof(int))]
	public TArray Unk004;

	[FieldOffset(60)]
	public int Unk005;

	[FieldOffset(64)]
	public int Unk006;

	[FieldOffset(68)]
	public TRef Unk007;

	[FieldOffset(84)]
	public int Unk008;

	[FieldOffset(88)]
	public TString Suffix;

	[FieldOffset(96)]
	public TRef Unk010;

}
