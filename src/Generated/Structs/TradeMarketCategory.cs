namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct TradeMarketCategory
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference Name;

	[FieldOffset(16)]
	[ReferenceTable("TradeMarketCategoryStyleFlag")]
	[EnumName("TradeMarketCategoryStyleFlag")]
	public TEnum StyleFlag;

	[FieldOffset(20)]
	[ReferenceTable("TradeMarketCategoryGroups")]
	public TableReference Group;

	[FieldOffset(36)]
	[ElementType(typeof(int))]
	public ArrayReference Unk004;

	[FieldOffset(52)]
	public TBool Unk005;

	[FieldOffset(53)]
	public TBool IsDisabled;

}
