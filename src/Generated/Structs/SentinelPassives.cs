using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SentinelPassives
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public int HASH16;

	[FieldOffset(12)]
	public TString Unk002;

	[FieldOffset(20)]
	[ElementType(typeof(TRef))]
	public TArray Unk003;

	[FieldOffset(36)]
	[ElementType(typeof(int))]
	public TArray Unk004;

	[FieldOffset(52)]
	public int Unk005;

	[FieldOffset(56)]
	public int Unk006;

	[FieldOffset(60)]
	public TRef Unk007;

	[FieldOffset(76)]
	public int Unk008;

	[FieldOffset(80)]
	public int Unk009;

	[FieldOffset(84)]
	public int Unk010;

}
