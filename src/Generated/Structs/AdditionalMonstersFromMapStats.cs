using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AdditionalMonstersFromMapStats
{
	[FieldOffset(0)]
	public TRef Unk000;

	[FieldOffset(16)]
	[ElementType(typeof(int))]
	public TArray Unk001;

	[FieldOffset(32)]
	public bool Unk002;

	[FieldOffset(33)]
	public int Unk003;

	[FieldOffset(37)]
	public int Unk004;

}
