namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BlightTopologyNodes
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ElementType(typeof(int))]
	public ArrayReference Unk001;

	[FieldOffset(24)]
	public int Size;

	[FieldOffset(28)]
	public int Angle;

	[FieldOffset(32)]
	[ElementType(typeof(int))]
	public ArrayReference Unk004;

	[FieldOffset(48)]
	[ElementType(typeof(int))]
	public ArrayReference Unk005;

	[FieldOffset(64)]
	[ElementType(typeof(int))]
	public ArrayReference Unk006;

	[FieldOffset(80)]
	[ElementType(typeof(int))]
	public ArrayReference Unk007;

	[FieldOffset(96)]
	[ElementType(typeof(int))]
	public ArrayReference Unk008;

	[FieldOffset(112)]
	[ElementType(typeof(int))]
	public ArrayReference Unk009;

	[FieldOffset(128)]
	public int Unk010;

}
