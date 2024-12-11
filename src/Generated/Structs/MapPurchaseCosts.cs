using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MapPurchaseCosts
{
	[FieldOffset(0)]
	public int Tier;

	[FieldOffset(4)]
	[ReferenceTable("ItemCosts")]
	public TRef Cost;

	[FieldOffset(20)]
	public TRef Unk002;

}
