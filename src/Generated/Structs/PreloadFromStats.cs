namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct PreloadFromStats
{
	[FieldOffset(0)]
	public TableReference Unk000;

	[FieldOffset(16)]
	[ElementType(typeof(int))]
	public ArrayReference Unk001;

	[FieldOffset(32)]
	[ElementType(typeof(int))]
	public ArrayReference Unk002;

	[FieldOffset(48)]
	[ElementType(typeof(int))]
	public ArrayReference Unk003;

	[FieldOffset(64)]
	[ElementType(typeof(int))]
	public ArrayReference Unk004;

	[FieldOffset(80)]
	public int Unk005;

}
