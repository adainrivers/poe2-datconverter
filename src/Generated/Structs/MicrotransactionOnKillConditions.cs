namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MicrotransactionOnKillConditions
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
	[ElementType(typeof(int))]
	public ArrayReference Unk003;

	[FieldOffset(56)]
	public int Unk004;

	[FieldOffset(60)]
	public TBool Unk005;

	[FieldOffset(61)]
	[ElementType(typeof(int))]
	public ArrayReference Unk006;

	[FieldOffset(77)]
	public int Unk007;

	[FieldOffset(81)]
	public int Unk008;

	[FieldOffset(85)]
	public int Unk009;

	[FieldOffset(89)]
	public TBool Unk010;

	[FieldOffset(90)]
	public StringReference Unk011;

	[FieldOffset(98)]
	[ElementType(typeof(StringReference))]
	public ArrayReference Unk012;

}
