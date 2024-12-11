using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Animation
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public bool Unk001;

	[FieldOffset(9)]
	public bool Unk002;

	[FieldOffset(10)]
	public bool Unk003;

	[FieldOffset(11)]
	[ReferenceTable("Animation")]
	public TRef Mainhand_AnimationKey;

	[FieldOffset(19)]
	[ReferenceTable("Animation")]
	public TRef Offhand_AnimationKey;

	[FieldOffset(27)]
	public bool Unk006;

	[FieldOffset(28)]
	public TRef Unk007;

	[FieldOffset(44)]
	[ReferenceTable("Animation")]
	public TRef Unk008;

	[FieldOffset(52)]
	public bool Unk009;

	[FieldOffset(53)]
	[ReferenceTable("Animation")]
	public TRef Unk010;

	[FieldOffset(61)]
	[ElementType(typeof(TString))]
	public TArray Unk011;

}
