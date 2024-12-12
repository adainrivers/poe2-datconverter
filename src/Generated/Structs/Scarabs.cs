namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Scarabs
{
	[FieldOffset(0)]
	[ReferenceTable("ScarabTypes")]
	public TableReference Type;

	[FieldOffset(16)]
	[ReferenceTable("BaseItemTypes")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Items;

}
