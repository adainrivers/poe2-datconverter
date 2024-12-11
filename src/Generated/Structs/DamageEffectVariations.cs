using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct DamageEffectVariations
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ElementType(typeof(int))]
	public TArray Unk001;

	[FieldOffset(24)]
	[ElementType(typeof(TString))]
	public TArray Unk002;

	[FieldOffset(40)]
	public TBool Unk003;

	[FieldOffset(41)]
	public int Unk004;

	[FieldOffset(45)]
	public int Unk005;

	[FieldOffset(49)]
	public int Unk006;

	[FieldOffset(53)]
	public int Unk007;

	[FieldOffset(57)]
	public int Unk008;

	[FieldOffset(61)]
	public int Unk009;

	[FieldOffset(65)]
	public int Unk010;

	[FieldOffset(69)]
	public int Unk011;

	[FieldOffset(73)]
	public int Unk012;

	[FieldOffset(77)]
	public TBool Unk013;

	[FieldOffset(78)]
	public TBool Unk014;

	[FieldOffset(79)]
	public TBool Unk015;

	[FieldOffset(80)]
	public TRef Unk016;

}
