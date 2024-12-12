namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct TieredMicrotransactions
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference MTX;

	[FieldOffset(16)]
	[ElementType(typeof(int))]
	public ArrayReference TierThresholds;

	[FieldOffset(32)]
	[ReferenceTable("Stats")]
	public TableReference Unk002;

	[FieldOffset(48)]
	[ElementType(typeof(int))]
	public ArrayReference Unk003;

	[FieldOffset(64)]
	[ReferenceTable("Stats")]
	public TableReference Unk004;

	[FieldOffset(80)]
	public int TierCount;

	[FieldOffset(84)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk006;

	[FieldOffset(100)]
	[ElementType(typeof(int))]
	public ArrayReference Unk007;

	[FieldOffset(116)]
	[ElementType(typeof(int))]
	public ArrayReference Unk008;

	[FieldOffset(132)]
	public TBool Unk009;

	[FieldOffset(133)]
	public TBool Unk010;

	[FieldOffset(134)]
	[ReferenceTable("Stats")]
	public TableReference Unk011;

	[FieldOffset(150)]
	public TBool Unk012;

}
