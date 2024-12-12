namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BlightedSporeAuras
{
	[FieldOffset(0)]
	[ReferenceTable("BuffDefinitions")]
	public TableReference BuffDefinitionsKey;

	[FieldOffset(16)]
	[ElementType(typeof(int))]
	public ArrayReference BuffStatValues;

	[FieldOffset(32)]
	public int Unk002;

	[FieldOffset(36)]
	[ElementType(typeof(int))]
	public ArrayReference Unk003;

	[FieldOffset(52)]
	public int Unk004;

}
