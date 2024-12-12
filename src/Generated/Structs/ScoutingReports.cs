namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ScoutingReports
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference BaseItemType;

	[FieldOffset(24)]
	public int MinMapTier;

}
