using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct TableCharge
{
	[FieldOffset(0)]
	public int Unk000;

	[FieldOffset(4)]
	public float Unk001;

	[FieldOffset(8)]
	public float Unk002;

	[FieldOffset(12)]
	public bool Unk003;

	[FieldOffset(13)]
	public TRef Unk004;

	[FieldOffset(29)]
	public bool Unk005;

	[FieldOffset(30)]
	[ElementType(typeof(TRef))]
	public TArray Unk006;

	[FieldOffset(46)]
	public TRef Unk007;

	[FieldOffset(62)]
	public int Unk008;

	[FieldOffset(66)]
	public int Unk009;

	[FieldOffset(70)]
	public int Unk010;

	[FieldOffset(74)]
	public int Unk011;

	[FieldOffset(78)]
	public bool Unk012;

	[FieldOffset(79)]
	public bool Unk013;

	[FieldOffset(80)]
	public TRef Unk014;

	[FieldOffset(96)]
	public TRef Unk015;

	[FieldOffset(112)]
	public int Unk016;

	[FieldOffset(116)]
	public bool Unk017;

	[FieldOffset(117)]
	public int Unk018;

	[FieldOffset(121)]
	public int Unk019;

	[FieldOffset(125)]
	public int Unk020;

	[FieldOffset(129)]
	public int Unk021;

	[FieldOffset(133)]
	public int Unk022;

	[FieldOffset(137)]
	public int Unk023;

	[FieldOffset(141)]
	public int Unk024;

	[FieldOffset(145)]
	public bool Unk025;

	[FieldOffset(146)]
	public bool Unk026;

	[FieldOffset(147)]
	public int Unk027;

}
