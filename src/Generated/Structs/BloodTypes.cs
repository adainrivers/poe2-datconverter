using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BloodTypes
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TRef Unk001;

	[FieldOffset(24)]
	public TRef Unk002;

	[FieldOffset(40)]
	[ElementType(typeof(TRef))]
	public TArray Unk003;

	[FieldOffset(56)]
	public TRef Unk004;

	[FieldOffset(72)]
	public TRef Unk005;

	[FieldOffset(88)]
	public TRef Unk006;

	[FieldOffset(104)]
	public TRef Unk007;

	[FieldOffset(120)]
	public TRef Unk008;

	[FieldOffset(136)]
	public TRef Unk009;

	[FieldOffset(152)]
	public TRef Unk010;

	[FieldOffset(168)]
	public TRef Unk011;

	[FieldOffset(184)]
	public TRef Unk012;

	[FieldOffset(200)]
	public TRef Unk013;

	[FieldOffset(216)]
	public TRef Unk014;

	[FieldOffset(232)]
	public TRef Unk015;

}
