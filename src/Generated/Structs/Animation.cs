namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Animation
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public TBool Unk001;

	[FieldOffset(9)]
	public TBool Unk002;

	[FieldOffset(10)]
	public TBool Unk003;

	[FieldOffset(11)]
	[ReferenceTable("Animation")]
	public TableReference Mainhand_AnimationKey;

	[FieldOffset(19)]
	[ReferenceTable("Animation")]
	public TableReference Offhand_AnimationKey;

	[FieldOffset(27)]
	public TBool Unk006;

	[FieldOffset(28)]
	public TableReference Unk007;

	[FieldOffset(44)]
	[ReferenceTable("Animation")]
	public TableReference Unk008;

	[FieldOffset(52)]
	public TBool Unk009;

	[FieldOffset(53)]
	[ReferenceTable("Animation")]
	public TableReference Unk010;

	[FieldOffset(61)]
	[ElementType(typeof(StringReference))]
	public ArrayReference Unk011;

}
