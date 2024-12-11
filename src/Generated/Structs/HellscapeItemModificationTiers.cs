using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HellscapeItemModificationTiers
{
	[FieldOffset(0)]
	public int Tier;

	[FieldOffset(4)]
	public bool IsMap;

	[FieldOffset(5)]
	public int Unk002;

	[FieldOffset(9)]
	public int MinItemLvl;

}
