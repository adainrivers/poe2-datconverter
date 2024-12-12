namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct StatVisuals
{
	[FieldOffset(0)]
	public TableReference Unk000;

	[FieldOffset(16)]
	[ElementType(typeof(StringReference))]
	public ArrayReference EPKFiles;

	[FieldOffset(32)]
	public TBool Unk002;

}
