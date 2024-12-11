using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct TradeMarketCategoryListAllClass
{
	[FieldOffset(0)]
	[ReferenceTable("TradeMarketCategory")]
	public TRef TradeCategory;

	[FieldOffset(16)]
	[ReferenceTable("ItemClasses")]
	public TRef ItemClass;

}
