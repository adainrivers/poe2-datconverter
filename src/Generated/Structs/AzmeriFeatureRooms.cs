namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AzmeriFeatureRooms
{
	[FieldOffset(0)]
	public int Unk000;

	[FieldOffset(4)]
	public int Unk001;

	[FieldOffset(8)]
	public StringReference Unk002;

	[FieldOffset(16)]
	public StringReference Unk003;

	[FieldOffset(24)]
	[ElementType(typeof(int))]
	public ArrayReference Unk004;

	[FieldOffset(40)]
	public TBool Unk005;

}
