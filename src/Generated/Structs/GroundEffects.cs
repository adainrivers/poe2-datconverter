namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct GroundEffects
{
	[FieldOffset(0)]
	[ReferenceTable("GroundEffectTypes")]
	public TableReference GroundEffectTypesKey;

	[FieldOffset(16)]
	public int Unk001;

	[FieldOffset(20)]
	public int Unk002;

	[FieldOffset(24)]
	public TableReference Unk003;

	[FieldOffset(40)]
	public float Unk004;

	[FieldOffset(44)]
	[ElementType(typeof(int))]
	public ArrayReference Unk005;

	[FieldOffset(60)]
	public TBool Unk006;

	[FieldOffset(61)]
	[ElementType(typeof(StringReference))]
	public ArrayReference AOFile;

	[FieldOffset(77)]
	[ElementType(typeof(StringReference))]
	public ArrayReference Unk008;

	[FieldOffset(93)]
	public StringReference EndEffect;

	[FieldOffset(101)]
	public TableReference Unk010;

	[FieldOffset(117)]
	public TableReference Unk011;

	[FieldOffset(133)]
	public TableReference Unk012;

	[FieldOffset(149)]
	public TableReference Unk013;

	[FieldOffset(165)]
	public TableReference Unk014;

	[FieldOffset(181)]
	public TBool Unk015;

	[FieldOffset(182)]
	public TBool Unk016;

	[FieldOffset(183)]
	public TBool Unk017;

	[FieldOffset(184)]
	public TableReference Unk018;

	[FieldOffset(200)]
	public TableReference Unk019;

	[FieldOffset(216)]
	public TBool Unk020;

	[FieldOffset(217)]
	public TBool Unk021;

	[FieldOffset(218)]
	public TBool Unk022;

}
