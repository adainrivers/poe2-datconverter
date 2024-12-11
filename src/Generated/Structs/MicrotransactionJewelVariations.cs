using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MicrotransactionJewelVariations
{
	[FieldOffset(0)]
	public TRef Unk000;

	[FieldOffset(16)]
	public int Unk001;

	[FieldOffset(20)]
	public TString Unk002;

	[FieldOffset(28)]
	public TString Unk003;

	[FieldOffset(36)]
	public int Unk004;

	[FieldOffset(40)]
	[ElementType(typeof(int))]
	public TArray Unk005;

	[FieldOffset(56)]
	public TString Unk006;

	[FieldOffset(64)]
	public TString Unk007;

	[FieldOffset(72)]
	public int Unk008;

	[FieldOffset(76)]
	public int Unk009;

	[FieldOffset(80)]
	public TString Unk010;

	[FieldOffset(88)]
	public int Unk011;

	[FieldOffset(92)]
	public TString Unk012;

	[FieldOffset(100)]
	public int Unk013;

	[FieldOffset(104)]
	public TBool Unk014;

	[FieldOffset(105)]
	public TRef Unk015;

	[FieldOffset(121)]
	public TBool Unk016;

}
