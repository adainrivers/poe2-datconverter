namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BloodTypes
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public TableReference Unk001;

	[FieldOffset(24)]
	public TableReference Unk002;

	[FieldOffset(40)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk003;

	[FieldOffset(56)]
	public TableReference Unk004;

	[FieldOffset(72)]
	public TableReference Unk005;

	[FieldOffset(88)]
	public TableReference Unk006;

	[FieldOffset(104)]
	public TableReference Unk007;

	[FieldOffset(120)]
	public TableReference Unk008;

	[FieldOffset(136)]
	public TableReference Unk009;

	[FieldOffset(152)]
	public TableReference Unk010;

	[FieldOffset(168)]
	public TableReference Unk011;

	[FieldOffset(184)]
	public TableReference Unk012;

	[FieldOffset(200)]
	public TableReference Unk013;

	[FieldOffset(216)]
	public TableReference Unk014;

	[FieldOffset(232)]
	public TableReference Unk015;

}
