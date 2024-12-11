using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BuffVisualOrbArt
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("MiscAnimated")]
	public TRef MiscAnimated;

	[FieldOffset(24)]
	[ElementType(typeof(int))]
	public TArray Unk002;

	[FieldOffset(40)]
	[ElementType(typeof(TString))]
	public TArray Unk003;

	[FieldOffset(56)]
	public TString Unk004;

	[FieldOffset(64)]
	public TString Unk005;

	[FieldOffset(72)]
	public TString Unk006;

	[FieldOffset(80)]
	public TString Unk007;

	[FieldOffset(88)]
	public int Unk008;

	[FieldOffset(92)]
	public TRef Unk009;

	[FieldOffset(108)]
	public TRef Unk010;

	[FieldOffset(124)]
	public TRef Unk011;

	[FieldOffset(140)]
	public TRef Unk012;

	[FieldOffset(156)]
	public bool Unk013;

	[FieldOffset(157)]
	public int Unk014;

}
