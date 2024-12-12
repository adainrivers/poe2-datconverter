namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct PackFrequencyNames
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public float Frequency;

	[FieldOffset(12)]
	[ReferenceTable("ClientStrings")]
	public TableReference Text;

}
