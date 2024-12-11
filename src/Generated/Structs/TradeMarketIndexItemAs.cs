using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct TradeMarketIndexItemAs
{
	[FieldOffset(0)]
	public TRef Item;

	[FieldOffset(16)]
	public TRef IndexAs;

}
