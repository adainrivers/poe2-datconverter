namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BreachArtVariations
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
	public TableReference Unk004;

	[FieldOffset(72)]
	public TableReference Unk005;

	[FieldOffset(88)]
	public TableReference Unk006;

	[FieldOffset(104)]
	public TableReference Unk007;

	[FieldOffset(120)]
	[ElementType(typeof(int))]
	public ArrayReference Unk008;

	[FieldOffset(136)]
	public TableReference Unk009;

}
