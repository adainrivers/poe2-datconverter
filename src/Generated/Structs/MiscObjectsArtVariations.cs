namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MiscObjectsArtVariations
{
	[FieldOffset(0)]
	public StringReference Unk000;

	[FieldOffset(8)]
	[ElementType(typeof(int))]
	public ArrayReference Unk001;

	[FieldOffset(24)]
	public int Unk002;

	[FieldOffset(28)]
	public int Unk003;

	[FieldOffset(32)]
	public TableReference Unk004;

}
