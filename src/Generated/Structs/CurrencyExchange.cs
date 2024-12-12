namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct CurrencyExchange
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference Item;

	[FieldOffset(16)]
	[ReferenceTable("CurrencyExchangeCategories")]
	public TableReference Category;

	[FieldOffset(32)]
	[ReferenceTable("CurrencyExchangeCategories")]
	public TableReference SubCategory;

	[FieldOffset(48)]
	public TBool Unk003;

	[FieldOffset(49)]
	public TBool EnabledInChallengeLeague;

	[FieldOffset(50)]
	public int GoldPurchaseFee;

	[FieldOffset(54)]
	public TBool Unk006;

}
