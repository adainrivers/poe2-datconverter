namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MetamorphosisStashTabLayout
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference StoredItem;

	[FieldOffset(24)]
	public int XOffset;

	[FieldOffset(28)]
	public int YOffset;

	[FieldOffset(32)]
	public int FirstSlotIndex;

	[FieldOffset(36)]
	public int Width;

	[FieldOffset(40)]
	public int Height;

	[FieldOffset(44)]
	public int SlotSize;

}
