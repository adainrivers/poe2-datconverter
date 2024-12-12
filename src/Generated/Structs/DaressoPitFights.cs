namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct DaressoPitFights
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
	public TBool Unk004;

	[FieldOffset(45)]
	public TBool Unk005;

	[FieldOffset(46)]
	public int Unk006;

	[FieldOffset(50)]
	public int Unk007;

	[FieldOffset(54)]
	public int Unk008;

	[FieldOffset(58)]
	public TBool Unk009;

}
