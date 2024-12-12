namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct FlaskStashBaseTypeOrdering
{
	[FieldOffset(0)]
	[ReferenceTable("Flasks")]
	public TableReference Flask;

	[FieldOffset(16)]
	public int Order;

}
