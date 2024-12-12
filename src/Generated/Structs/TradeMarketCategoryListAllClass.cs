namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct TradeMarketCategoryListAllClass
{
	[FieldOffset(0)]
	[ReferenceTable("TradeMarketCategory")]
	public TableReference TradeCategory;

	[FieldOffset(16)]
	[ReferenceTable("ItemClasses")]
	public TableReference ItemClass;

}
