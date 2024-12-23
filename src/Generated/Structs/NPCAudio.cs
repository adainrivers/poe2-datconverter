namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct NPCAudio
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ElementType(typeof(int))]
	public ArrayReference Unk001;

	[FieldOffset(24)]
	[ElementType(typeof(int))]
	public ArrayReference Unk002;

	[FieldOffset(40)]
	public int VolumePercentage;

	[FieldOffset(44)]
	public int Unk004;

	[FieldOffset(48)]
	public int Unk005;

	[FieldOffset(52)]
	public int Unk006;

	[FieldOffset(56)]
	public int Unk007;

	[FieldOffset(60)]
	public TableReference Unk008;

	[FieldOffset(76)]
	public int Unk009;

	[FieldOffset(80)]
	public int Unk010;

}
