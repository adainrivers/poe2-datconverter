namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct UniqueJewelLimits
{
	[FieldOffset(0)]
	[ReferenceTable("Words")]
	public TableReference JewelName;

	[FieldOffset(16)]
	public int Limit;

}
