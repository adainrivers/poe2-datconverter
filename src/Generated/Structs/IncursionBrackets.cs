namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct IncursionBrackets
{
	[FieldOffset(0)]
	public int MinLevel;

	[FieldOffset(4)]
	[ReferenceTable("WorldAreas")]
	public TableReference Incursion_WorldAreasKey;

	[FieldOffset(20)]
	[ReferenceTable("WorldAreas")]
	public TableReference Template_WorldAreasKey;

	[FieldOffset(36)]
	[ElementType(typeof(float))]
	public ArrayReference Unk003;

	[FieldOffset(52)]
	public float Unk004;

	[FieldOffset(56)]
	public int Unk005;

}
