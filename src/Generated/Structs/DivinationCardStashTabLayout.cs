namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct DivinationCardStashTabLayout
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference StoredItem;

	[FieldOffset(16)]
	public TBool IsInGame;

	[FieldOffset(17)]
	public TBool IsEnabled;

}
