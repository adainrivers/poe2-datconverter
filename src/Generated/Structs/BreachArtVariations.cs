using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BreachArtVariations
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
	public TRef Unk004;

	[FieldOffset(72)]
	public TRef Unk005;

	[FieldOffset(88)]
	public TRef Unk006;

	[FieldOffset(104)]
	public TRef Unk007;

	[FieldOffset(120)]
	[ElementType(typeof(int))]
	public TArray Unk008;

	[FieldOffset(136)]
	public TRef Unk009;

}
