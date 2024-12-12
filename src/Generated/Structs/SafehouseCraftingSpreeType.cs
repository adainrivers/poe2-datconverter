namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SafehouseCraftingSpreeType
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("SafehouseCraftingSpreeCurrencies")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Currencies;

	[FieldOffset(24)]
	[ElementType(typeof(int))]
	public ArrayReference CurrencyCount;

	[FieldOffset(40)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk003;

	[FieldOffset(56)]
	public TBool Disabled;

	[FieldOffset(57)]
	public StringReference ItemClassText;

	[FieldOffset(65)]
	public int Unk006;

}
