namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct RunicCircles
{
	[FieldOffset(0)]
	public StringReference Unk000;

	[FieldOffset(8)]
	public int Unk001;

	[FieldOffset(12)]
	[ElementType(typeof(int))]
	public ArrayReference Unk002;

	[FieldOffset(28)]
	public int Unk003;

}
