namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MicrotransactionCombineFormula
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference Result_BaseItemTypesKey;

	[FieldOffset(24)]
	[ReferenceTable("BaseItemTypes")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Ingredients_BaseItemTypesKeys;

	[FieldOffset(40)]
	public StringReference BK2File;

	[FieldOffset(48)]
	[ElementType(typeof(int))]
	public ArrayReference Unk004;

	[FieldOffset(64)]
	public int Unk005;

	[FieldOffset(68)]
	public TBool Unk006;

}
