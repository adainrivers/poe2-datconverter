namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct CraftingItemClassCategories
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("ItemClasses")]
	[ElementType(typeof(TableReference))]
	public ArrayReference ItemClasses;

	[FieldOffset(24)]
	public StringReference Unk002;

	[FieldOffset(32)]
	public StringReference Text;

	[FieldOffset(40)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk004;

}
