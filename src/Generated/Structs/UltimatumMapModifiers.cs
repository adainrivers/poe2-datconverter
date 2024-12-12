namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct UltimatumMapModifiers
{
	[FieldOffset(0)]
	[ReferenceTable("Stats")]
	public TableReference Stat;

	[FieldOffset(16)]
	[ReferenceTable("UltimatumModifiers")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Mods;

}
