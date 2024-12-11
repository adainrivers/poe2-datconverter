using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MicrotransactionOnKillConditions
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ElementType(typeof(int))]
	public TArray Unk001;

	[FieldOffset(24)]
	[ElementType(typeof(int))]
	public TArray Unk002;

	[FieldOffset(40)]
	[ElementType(typeof(int))]
	public TArray Unk003;

	[FieldOffset(56)]
	public int Unk004;

	[FieldOffset(60)]
	public TBool Unk005;

	[FieldOffset(61)]
	[ElementType(typeof(int))]
	public TArray Unk006;

	[FieldOffset(77)]
	public int Unk007;

	[FieldOffset(81)]
	public int Unk008;

	[FieldOffset(85)]
	public int Unk009;

	[FieldOffset(89)]
	public TBool Unk010;

	[FieldOffset(90)]
	public TString Unk011;

	[FieldOffset(98)]
	[ElementType(typeof(TString))]
	public TArray Unk012;

}
