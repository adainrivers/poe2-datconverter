namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AegisVariations
{
	[FieldOffset(0)]
	public StringReference Name;

	[FieldOffset(8)]
	public TBool DefendsAgainstPhysical;

	[FieldOffset(9)]
	public TBool DefendsAgainstFire;

	[FieldOffset(10)]
	public TBool DefendsAgainstCold;

	[FieldOffset(11)]
	public TBool DefendsAgainstLightning;

	[FieldOffset(12)]
	public TBool DefendsAgainstChaos;

	[FieldOffset(13)]
	public TableReference Unk006;

	[FieldOffset(29)]
	public TableReference Unk007;

	[FieldOffset(45)]
	public TableReference Unk008;

	[FieldOffset(61)]
	public TableReference Unk009;

	[FieldOffset(77)]
	[ElementType(typeof(int))]
	public ArrayReference Unk010;

}
