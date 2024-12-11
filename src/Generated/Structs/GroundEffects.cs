using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct GroundEffects
{
	[FieldOffset(0)]
	[ReferenceTable("GroundEffectTypes")]
	public TRef GroundEffectTypesKey;

	[FieldOffset(16)]
	public int Unk001;

	[FieldOffset(20)]
	public int Unk002;

	[FieldOffset(24)]
	public TRef Unk003;

	[FieldOffset(40)]
	public float Unk004;

	[FieldOffset(44)]
	[ElementType(typeof(int))]
	public TArray Unk005;

	[FieldOffset(60)]
	public bool Unk006;

	[FieldOffset(61)]
	[ElementType(typeof(TString))]
	public TArray AOFile;

	[FieldOffset(77)]
	[ElementType(typeof(TString))]
	public TArray Unk008;

	[FieldOffset(93)]
	public TString EndEffect;

	[FieldOffset(101)]
	public TRef Unk010;

	[FieldOffset(117)]
	public TRef Unk011;

	[FieldOffset(133)]
	public TRef Unk012;

	[FieldOffset(149)]
	public TRef Unk013;

	[FieldOffset(165)]
	public TRef Unk014;

	[FieldOffset(181)]
	public bool Unk015;

	[FieldOffset(182)]
	public bool Unk016;

	[FieldOffset(183)]
	public bool Unk017;

	[FieldOffset(184)]
	public TRef Unk018;

	[FieldOffset(200)]
	public TRef Unk019;

	[FieldOffset(216)]
	public bool Unk020;

	[FieldOffset(217)]
	public bool Unk021;

	[FieldOffset(218)]
	public bool Unk022;

}
