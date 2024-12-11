using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct DropPool
{
	[FieldOffset(0)]
	public TString Group;

	[FieldOffset(8)]
	public int Weight;

	[FieldOffset(12)]
	[ElementType(typeof(int))]
	public TArray Unk002;

	[FieldOffset(28)]
	public int WeightHardmode;

}
