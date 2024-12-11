using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SentinelCraftingCurrency
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TRef Currency;

	[FieldOffset(16)]
	public int Type;

}
