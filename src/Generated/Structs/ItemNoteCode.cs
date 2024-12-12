namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ItemNoteCode
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference BaseItem;

	[FieldOffset(16)]
	public StringReference Code;

	[FieldOffset(24)]
	public int Order1;

	[FieldOffset(28)]
	public TBool Show;

	[FieldOffset(29)]
	public int Order2;

}
