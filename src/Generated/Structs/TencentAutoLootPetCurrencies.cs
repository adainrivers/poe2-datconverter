namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct TencentAutoLootPetCurrencies
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference BaseItemTypesKey;

	[FieldOffset(16)]
	public TBool Unk001;

	[FieldOffset(17)]
	[ElementType(typeof(int))]
	public ArrayReference Unk002;

}
