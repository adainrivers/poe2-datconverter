namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct TriggerBeam
{
	[FieldOffset(0)]
	public int Unk000;

	[FieldOffset(4)]
	[ReferenceTable("MiscBeams")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk001;

	[FieldOffset(20)]
	[ReferenceTable("MiscBeams")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk002;

	[FieldOffset(36)]
	[ElementType(typeof(int))]
	public ArrayReference Unk003;

	[FieldOffset(52)]
	public TBool Unk004;

	[FieldOffset(53)]
	public int Unk005;

	[FieldOffset(57)]
	public int Unk006;

	[FieldOffset(61)]
	public int Unk007;

	[FieldOffset(65)]
	public int Unk008;

	[FieldOffset(69)]
	public TBool Unk009;

	[FieldOffset(70)]
	[ElementType(typeof(int))]
	public ArrayReference Unk010;

	[FieldOffset(86)]
	public TBool Unk011;

	[FieldOffset(87)]
	public int Unk012;

	[FieldOffset(91)]
	public TBool Unk013;

}
