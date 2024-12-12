namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct PassiveTreeExpansionJewels
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference BaseItemTypesKey;

	[FieldOffset(16)]
	[ReferenceTable("PassiveTreeExpansionJewelSizes")]
	public TableReference PassiveTreeExpansionJewelSizesKey;

	[FieldOffset(32)]
	public int MinNodes;

	[FieldOffset(36)]
	public int MaxNodes;

	[FieldOffset(40)]
	[ElementType(typeof(int))]
	public ArrayReference SmallIndices;

	[FieldOffset(56)]
	[ElementType(typeof(int))]
	public ArrayReference NotableIndices;

	[FieldOffset(72)]
	[ElementType(typeof(int))]
	public ArrayReference SocketIndices;

	[FieldOffset(88)]
	public int TotalIndices;

}
