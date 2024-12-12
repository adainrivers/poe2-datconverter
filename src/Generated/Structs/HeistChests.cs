namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HeistChests
{
	[FieldOffset(0)]
	[ReferenceTable("Chests")]
	public TableReference ChestsKey;

	[FieldOffset(16)]
	public int Weight;

	[FieldOffset(20)]
	[ReferenceTable("HeistAreas")]
	[ElementType(typeof(TableReference))]
	public ArrayReference HeistAreasKey;

	[FieldOffset(36)]
	[ReferenceTable("HeistChestTypes")]
	[EnumName("HeistChestTypes")]
	public TEnum HeistChestTypesKey;

}
