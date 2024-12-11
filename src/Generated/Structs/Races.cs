using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Races
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TRef))]
	public TArray Mods;

	[FieldOffset(24)]
	public TString Unk002;

	[FieldOffset(32)]
	public TString Unk003;

	[FieldOffset(40)]
	public int Unk004;

	[FieldOffset(44)]
	public int Unk005;

	[FieldOffset(48)]
	[ElementType(typeof(TRef))]
	public TArray Unk006;

	[FieldOffset(64)]
	public bool Unk007;

	[FieldOffset(65)]
	public int Unk008;

	[FieldOffset(69)]
	[ElementType(typeof(int))]
	public TArray Unk009;

	[FieldOffset(85)]
	[ElementType(typeof(int))]
	public TArray Unk010;

}
