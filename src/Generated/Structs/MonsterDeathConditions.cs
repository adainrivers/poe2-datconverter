using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MonsterDeathConditions
{
	[FieldOffset(0)]
	public TString Unk000;

	[FieldOffset(8)]
	[ElementType(typeof(TRef))]
	public TArray Unk001;

	[FieldOffset(24)]
	public bool Unk002;

	[FieldOffset(25)]
	public int Unk003;

	[FieldOffset(29)]
	[ElementType(typeof(TRef))]
	public TArray Unk004;

	[FieldOffset(45)]
	public bool Unk005;

	[FieldOffset(46)]
	public int Unk006;

	[FieldOffset(50)]
	public TRef Unk007;

	[FieldOffset(66)]
	public bool Unk008;

	[FieldOffset(67)]
	[ElementType(typeof(TRef))]
	public TArray Unk009;

	[FieldOffset(83)]
	public int Unk010;

	[FieldOffset(87)]
	public bool Unk011;

	[FieldOffset(88)]
	[ElementType(typeof(TRef))]
	public TArray Unk012;

	[FieldOffset(104)]
	public int Unk013;

	[FieldOffset(108)]
	public TRef Unk014;

	[FieldOffset(124)]
	public TRef Unk015;

	[FieldOffset(140)]
	public int Unk016;

	[FieldOffset(144)]
	public int Unk017;

}
