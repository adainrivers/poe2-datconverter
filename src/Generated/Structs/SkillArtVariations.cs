using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SkillArtVariations
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ElementType(typeof(TRef))]
	public TArray Unk001;

	[FieldOffset(24)]
	[ElementType(typeof(int))]
	public TArray Unk002;

	[FieldOffset(40)]
	[ElementType(typeof(int))]
	public TArray Unk003;

	[FieldOffset(56)]
	[ElementType(typeof(int))]
	public TArray Unk004;

	[FieldOffset(72)]
	[ElementType(typeof(TString))]
	public TArray Variants;

	[FieldOffset(88)]
	[ElementType(typeof(TRef))]
	public TArray Unk006;

	[FieldOffset(104)]
	[ElementType(typeof(int))]
	public TArray Unk007;

	[FieldOffset(120)]
	[ElementType(typeof(TRef))]
	public TArray Unk008;

	[FieldOffset(136)]
	public TRef Unk009;

	[FieldOffset(152)]
	[ElementType(typeof(int))]
	public TArray Unk010;

	[FieldOffset(168)]
	[ElementType(typeof(TRef))]
	public TArray Unk011;

	[FieldOffset(184)]
	[ElementType(typeof(int))]
	public TArray Unk012;

}
