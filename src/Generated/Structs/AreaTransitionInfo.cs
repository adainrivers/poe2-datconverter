using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AreaTransitionInfo
{
	[FieldOffset(0)]
	public TRef Unk000;

	[FieldOffset(16)]
	public TRef Unk001;

	[FieldOffset(32)]
	public TRef Unk002;

	[FieldOffset(48)]
	public TRef Unk003;

	[FieldOffset(64)]
	public TRef Unk004;

	[FieldOffset(80)]
	public TRef Unk005;

	[FieldOffset(96)]
	public TRef Unk006;

	[FieldOffset(112)]
	public TRef Unk007;

	[FieldOffset(128)]
	public TRef Unk008;

	[FieldOffset(144)]
	public TRef Unk009;

	[FieldOffset(160)]
	public TRef Unk010;

	[FieldOffset(176)]
	[ElementType(typeof(TRef))]
	public TArray Unk011;

	[FieldOffset(192)]
	public int Unk012;

	[FieldOffset(196)]
	[ElementType(typeof(TRef))]
	public TArray Unk013;

}
