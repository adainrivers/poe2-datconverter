namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ExpandingPulse
{
	[FieldOffset(0)]
	public int IntId;

	[FieldOffset(4)]
	public StringReference StringId;

	[FieldOffset(12)]
	[ElementType(typeof(int))]
	public ArrayReference Unk002;

	[FieldOffset(28)]
	[ElementType(typeof(float))]
	public ArrayReference Unk003;

	[FieldOffset(44)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk004;

	[FieldOffset(60)]
	public int Unk005;

	[FieldOffset(64)]
	public int Unk006;

	[FieldOffset(68)]
	public TBool Unk007;

}
