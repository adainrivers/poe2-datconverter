using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MapTiers
{
	[FieldOffset(0)]
	public int Tier;

	[FieldOffset(4)]
	public int Level;

	[FieldOffset(8)]
	public int Level2;

}
