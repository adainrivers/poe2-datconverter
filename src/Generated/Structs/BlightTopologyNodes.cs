using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BlightTopologyNodes
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ElementType(typeof(int))]
	public TArray Unk001;

	[FieldOffset(24)]
	public int Size;

	[FieldOffset(28)]
	public int Angle;

	[FieldOffset(32)]
	[ElementType(typeof(int))]
	public TArray Unk004;

	[FieldOffset(48)]
	[ElementType(typeof(int))]
	public TArray Unk005;

	[FieldOffset(64)]
	[ElementType(typeof(int))]
	public TArray Unk006;

	[FieldOffset(80)]
	[ElementType(typeof(int))]
	public TArray Unk007;

	[FieldOffset(96)]
	[ElementType(typeof(int))]
	public TArray Unk008;

	[FieldOffset(112)]
	[ElementType(typeof(int))]
	public TArray Unk009;

	[FieldOffset(128)]
	public int Unk010;

}
