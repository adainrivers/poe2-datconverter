namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ItemisedNecropolisPacks
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference Item;

	[FieldOffset(16)]
	[ReferenceTable("NecropolisPacks")]
	public TableReference Pack;

	[FieldOffset(32)]
	public StringReference Description;

}
