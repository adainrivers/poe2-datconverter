using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SpawnObject
{
	[FieldOffset(0)]
	public int Unk000;

	[FieldOffset(4)]
	[ElementType(typeof(TRef))]
	public TArray Unk001;

	[FieldOffset(20)]
	[ElementType(typeof(int))]
	public TArray Unk002;

	[FieldOffset(36)]
	public int Unk003;

	[FieldOffset(40)]
	public int Unk004;

	[FieldOffset(44)]
	public int Unk005;

	[FieldOffset(48)]
	public int Unk006;

	[FieldOffset(52)]
	public int Unk007;

	[FieldOffset(56)]
	public int Unk008;

	[FieldOffset(60)]
	public int Unk009;

	[FieldOffset(64)]
	public int Unk010;

	[FieldOffset(68)]
	public TBool Unk011;

	[FieldOffset(69)]
	public TString Unk012;

	[FieldOffset(77)]
	public int Unk013;

	[FieldOffset(81)]
	public TBool Unk014;

	[FieldOffset(82)]
	public int Unk015;

}
