namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HeistObjectives
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference BaseItemType;

	[FieldOffset(16)]
	public float Scaling;

	[FieldOffset(20)]
	public StringReference Name;

}
