namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct DelveCraftingTags
{
	[FieldOffset(0)]
	[ReferenceTable("Tags")]
	public TableReference TagsKey;

	[FieldOffset(16)]
	public StringReference ItemClass;

}
