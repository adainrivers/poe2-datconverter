using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MonsterConditions
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
	[ElementType(typeof(TRef))]
	public TArray Unk004;

	[FieldOffset(72)]
	public TBool Unk005;

	[FieldOffset(73)]
	public TBool Unk006;

	[FieldOffset(74)]
	[ElementType(typeof(TRef))]
	public TArray Unk007;

	[FieldOffset(90)]
	[ElementType(typeof(TString))]
	public TArray Unk008;

	[FieldOffset(106)]
	public int Unk009;

	[FieldOffset(110)]
	public int Unk010;

	[FieldOffset(114)]
	public int Unk011;

	[FieldOffset(118)]
	public int Unk012;

}
