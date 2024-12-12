namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AreaTransitionInfo
{
	[FieldOffset(0)]
	public TableReference Unk000;

	[FieldOffset(16)]
	public TableReference Unk001;

	[FieldOffset(32)]
	public TableReference Unk002;

	[FieldOffset(48)]
	public TableReference Unk003;

	[FieldOffset(64)]
	public TableReference Unk004;

	[FieldOffset(80)]
	public TableReference Unk005;

	[FieldOffset(96)]
	public TableReference Unk006;

	[FieldOffset(112)]
	public TableReference Unk007;

	[FieldOffset(128)]
	public TableReference Unk008;

	[FieldOffset(144)]
	public TableReference Unk009;

	[FieldOffset(160)]
	public TableReference Unk010;

	[FieldOffset(176)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk011;

	[FieldOffset(192)]
	public int Unk012;

	[FieldOffset(196)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk013;

}
