using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct DelveMonsterSpawners
{
	[FieldOffset(0)]
	public TString BaseMetadata;

	[FieldOffset(8)]
	public int Unk001;

	[FieldOffset(12)]
	[ElementType(typeof(TRef))]
	public TArray Unk002;

	[FieldOffset(28)]
	public int Unk003;

	[FieldOffset(32)]
	public int Unk004;

	[FieldOffset(36)]
	public int Unk005;

	[FieldOffset(40)]
	public int Unk006;

	[FieldOffset(44)]
	public int Unk007;

	[FieldOffset(48)]
	public int Unk008;

	[FieldOffset(52)]
	public int Unk009;

	[FieldOffset(56)]
	public int Unk010;

	[FieldOffset(60)]
	public bool Unk011;

	[FieldOffset(61)]
	public bool Unk012;

	[FieldOffset(62)]
	public bool Unk013;

	[FieldOffset(63)]
	public bool Unk014;

	[FieldOffset(64)]
	public bool Unk015;

	[FieldOffset(65)]
	public bool Unk016;

	[FieldOffset(66)]
	public bool Unk017;

	[FieldOffset(67)]
	public bool Unk018;

	[FieldOffset(68)]
	public bool Unk019;

	[FieldOffset(69)]
	public bool Unk020;

	[FieldOffset(70)]
	public int Unk021;

	[FieldOffset(74)]
	public int Unk022;

	[FieldOffset(78)]
	public int Unk023;

	[FieldOffset(82)]
	public int Unk024;

	[FieldOffset(86)]
	public TRef Unk025;

	[FieldOffset(102)]
	public bool Unk026;

	[FieldOffset(103)]
	public bool Unk027;

	[FieldOffset(104)]
	public int Unk028;

	[FieldOffset(108)]
	public TString Script;

	[FieldOffset(116)]
	public bool Unk030;

}
