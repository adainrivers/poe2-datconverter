namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct CraftingBenchUnlockCategories
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public int Unk001;

	[FieldOffset(12)]
	[ElementType(typeof(int))]
	public ArrayReference Unk002;

	[FieldOffset(28)]
	public StringReference UnlockType;

	[FieldOffset(36)]
	[ReferenceTable("CraftingItemClassCategories")]
	[ElementType(typeof(TableReference))]
	public ArrayReference CraftingItemClassCategories;

	[FieldOffset(52)]
	public StringReference ObtainingDescription;

}
