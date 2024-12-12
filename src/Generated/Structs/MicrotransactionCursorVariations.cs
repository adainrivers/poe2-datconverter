namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MicrotransactionCursorVariations
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference Unk000;

	[FieldOffset(16)]
	public TableReference Unk001;

	[FieldOffset(32)]
	public int Unk002;

}
