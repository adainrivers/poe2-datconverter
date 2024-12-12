namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MTXSetBonus
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public TableReference Unk001;

	[FieldOffset(24)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk002;

	[FieldOffset(40)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk003;

	[FieldOffset(56)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk004;

	[FieldOffset(72)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk005;

}
