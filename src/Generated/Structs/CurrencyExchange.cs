using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct CurrencyExchange
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TRef Item;

	[FieldOffset(16)]
	[ReferenceTable("CurrencyExchangeCategories")]
	public TRef Category;

	[FieldOffset(32)]
	[ReferenceTable("CurrencyExchangeCategories")]
	public TRef SubCategory;

	[FieldOffset(48)]
	public bool Unk003;

	[FieldOffset(49)]
	public bool EnabledInChallengeLeague;

	[FieldOffset(50)]
	public int GoldPurchaseFee;

	[FieldOffset(54)]
	public bool Unk006;

}
