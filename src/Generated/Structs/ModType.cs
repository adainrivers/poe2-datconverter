namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ModType
{
	[FieldOffset(0)]
	public StringReference Name;

	[FieldOffset(8)]
	[ReferenceTable("ModSellPriceTypes")]
	[ElementType(typeof(TableReference))]
	public ArrayReference ModSellPriceTypesKeys;

	[FieldOffset(24)]
	public TBool Unk002;

}
