namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Footprints
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ElementType(typeof(StringReference))]
	public ArrayReference Active_AOFiles;

	[FieldOffset(24)]
	[ElementType(typeof(StringReference))]
	public ArrayReference Idle_AOFiles;

	[FieldOffset(40)]
	[ElementType(typeof(StringReference))]
	public ArrayReference Unk003;

	[FieldOffset(56)]
	[ElementType(typeof(StringReference))]
	public ArrayReference Unk004;

	[FieldOffset(72)]
	public int Unk005;

	[FieldOffset(76)]
	public TableReference Unk006;

}
