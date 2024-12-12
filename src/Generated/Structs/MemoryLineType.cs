namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MemoryLineType
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public TableReference Unk001;

	[FieldOffset(24)]
	public int Unk002;

	[FieldOffset(28)]
	[ElementType(typeof(int))]
	public ArrayReference Unk003;

	[FieldOffset(44)]
	[ElementType(typeof(int))]
	public ArrayReference Unk004;

	[FieldOffset(60)]
	public int Unk005;

	[FieldOffset(64)]
	public int Unk006;

	[FieldOffset(68)]
	public TableReference Unk007;

	[FieldOffset(84)]
	public int Unk008;

	[FieldOffset(88)]
	public StringReference Suffix;

	[FieldOffset(96)]
	public TableReference Unk010;

}
