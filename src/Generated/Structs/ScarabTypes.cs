namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ScarabTypes
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("Tags")]
	public TableReference Tag;

	[FieldOffset(24)]
	[ReferenceTable("Stats")]
	public TableReference DisableDrops;

	[FieldOffset(40)]
	[ReferenceTable("Stats")]
	public TableReference MoreLikely;

	[FieldOffset(56)]
	[ReferenceTable("Stats")]
	public TableReference Count;

}
