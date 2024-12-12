namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct TypeTags
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("Tags")]
	public TableReference Tag;

	[FieldOffset(24)]
	public StringReference Name;

	[FieldOffset(32)]
	public StringReference Icon;

	[FieldOffset(40)]
	[ReferenceTable("Stats")]
	public TableReference Unk004;

}
