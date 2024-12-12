namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct CraftingBenchSortCategories
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("ClientStrings")]
	public TableReference Name;

	[FieldOffset(24)]
	public TBool IsVisible;

	[FieldOffset(25)]
	[ReferenceTable("CraftingBenchTypes")]
	public TableReference Type;

}
