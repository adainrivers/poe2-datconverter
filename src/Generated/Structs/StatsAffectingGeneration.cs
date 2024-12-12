namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct StatsAffectingGeneration
{
	[FieldOffset(0)]
	[ReferenceTable("Stats")]
	public TableReference Stat;

	[FieldOffset(16)]
	public int StatValue;

}
