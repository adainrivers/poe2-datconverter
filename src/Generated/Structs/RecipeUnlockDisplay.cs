namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct RecipeUnlockDisplay
{
	[FieldOffset(0)]
	public int RecipeId;

	[FieldOffset(4)]
	public StringReference Description;

	[FieldOffset(12)]
	[ReferenceTable("CraftingItemClassCategories")]
	[ElementType(typeof(TableReference))]
	public ArrayReference CraftingItemClassCategoriesKeys;

	[FieldOffset(28)]
	public StringReference UnlockDescription;

	[FieldOffset(36)]
	public int Rank;

	[FieldOffset(40)]
	[ReferenceTable("WorldAreas")]
	public TableReference UnlockArea;

}
