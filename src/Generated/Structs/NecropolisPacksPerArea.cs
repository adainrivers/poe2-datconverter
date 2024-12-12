namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct NecropolisPacksPerArea
{
	[FieldOffset(0)]
	public TableReference Unk000;

	[FieldOffset(16)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk001;

	[FieldOffset(32)]
	[ElementType(typeof(int))]
	public ArrayReference Unk002;

}
