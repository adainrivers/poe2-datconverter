using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct VillageFarmAdjacency
{
	[FieldOffset(0)]
	public int Unk000;

	[FieldOffset(4)]
	[ElementType(typeof(int))]
	public TArray Unk001;

}
