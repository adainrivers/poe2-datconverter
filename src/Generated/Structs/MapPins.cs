using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MapPins
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public ulong Unk001;

	[FieldOffset(16)]
	public ulong Unk002;

	[FieldOffset(24)]
	public ulong Unk003;

	[FieldOffset(32)]
	public int Unk004;

	[FieldOffset(36)]
	public int Unk005;

	[FieldOffset(40)]
	public TString Name;

	[FieldOffset(48)]
	public TString Description;

	[FieldOffset(56)]
	public ulong Unk008;

	[FieldOffset(64)]
	[ElementType(typeof(int))]
	public TArray Unk009;

	[FieldOffset(80)]
	public int Unk010;

	[FieldOffset(84)]
	[ElementType(typeof(int))]
	public TArray Unk011;

	[FieldOffset(100)]
	public int Unk012;

	[FieldOffset(104)]
	public int Unk013;

	[FieldOffset(108)]
	public TString Unk014;

	[FieldOffset(116)]
	public TString Unk015;

	[FieldOffset(124)]
	public TString Unk016;

}
