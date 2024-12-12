namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MicrotransactionObjectEffects
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ElementType(typeof(int))]
	public ArrayReference Unk001;

	[FieldOffset(24)]
	public StringReference Script;

	[FieldOffset(32)]
	[ElementType(typeof(int))]
	public ArrayReference Unk003;

	[FieldOffset(48)]
	[ElementType(typeof(int))]
	public ArrayReference Unk004;

	[FieldOffset(64)]
	public TableReference Unk005;

	[FieldOffset(80)]
	[ElementType(typeof(int))]
	public ArrayReference Unk006;

	[FieldOffset(96)]
	public int Unk007;

	[FieldOffset(100)]
	public int Unk008;

	[FieldOffset(104)]
	public int Unk009;

	[FieldOffset(108)]
	public int Unk010;

	[FieldOffset(112)]
	public int Unk011;

	[FieldOffset(116)]
	public int Unk012;

	[FieldOffset(120)]
	public int Unk013;

	[FieldOffset(124)]
	public int Unk014;

	[FieldOffset(128)]
	public int Unk015;

	[FieldOffset(132)]
	public int Unk016;

}
