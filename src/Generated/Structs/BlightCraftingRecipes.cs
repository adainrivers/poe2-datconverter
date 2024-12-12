namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BlightCraftingRecipes
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("BlightCraftingItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference BlightCraftingItemsKeys;

	[FieldOffset(24)]
	[ReferenceTable("BlightCraftingResults")]
	public TableReference BlightCraftingResultsKey;

	[FieldOffset(40)]
	[ReferenceTable("BlightCraftingTypes")]
	public TableReference BlightCraftingTypesKey;

}
