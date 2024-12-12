namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AdditionalMonstersFromMapStats
{
	[FieldOffset(0)]
	public TableReference Unk000;

	[FieldOffset(16)]
	[ElementType(typeof(int))]
	public ArrayReference Unk001;

	[FieldOffset(32)]
	public TBool Unk002;

	[FieldOffset(33)]
	public int Unk003;

	[FieldOffset(37)]
	public int Unk004;

}
