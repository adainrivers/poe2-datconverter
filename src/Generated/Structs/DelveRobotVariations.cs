namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct DelveRobotVariations
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference AOFile;

	[FieldOffset(16)]
	[ElementType(typeof(StringReference))]
	public ArrayReference Unk002;

	[FieldOffset(32)]
	public TableReference Unk003;

	[FieldOffset(48)]
	public TableReference Unk004;

}
