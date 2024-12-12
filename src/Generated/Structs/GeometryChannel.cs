namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct GeometryChannel
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public TableReference Unk001;

	[FieldOffset(24)]
	public TableReference Unk002;

	[FieldOffset(40)]
	public TableReference Unk003;

	[FieldOffset(56)]
	public StringReference Unk004;

	[FieldOffset(64)]
	public StringReference Unk005;

	[FieldOffset(72)]
	public StringReference Unk006;

	[FieldOffset(80)]
	public TBool Unk007;

	[FieldOffset(81)]
	public TBool Unk008;

	[FieldOffset(82)]
	public TableReference Unk009;

	[FieldOffset(98)]
	public TableReference Unk010;

	[FieldOffset(114)]
	public StringReference EPKFile;

	[FieldOffset(122)]
	public int Unk012;

	[FieldOffset(126)]
	public int Unk013;

}
