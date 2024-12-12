namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct RaceTimes
{
	[FieldOffset(0)]
	[ReferenceTable("Races")]
	public TableReference RacesKey;

	[FieldOffset(16)]
	public int Index;

	[FieldOffset(20)]
	public int StartUNIXTime;

	[FieldOffset(24)]
	public int EndUNIXTime;

}
