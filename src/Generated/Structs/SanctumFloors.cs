namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SanctumFloors
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("WorldAreas")]
	public TableReference Area;

	[FieldOffset(24)]
	[ReferenceTable("ClientStrings")]
	public TableReference Title;

	[FieldOffset(40)]
	public StringReference RoomIcon;

	[FieldOffset(48)]
	public StringReference BossIcon;

	[FieldOffset(56)]
	public StringReference Description;

	[FieldOffset(64)]
	[ReferenceTable("ClientStrings")]
	public TableReference Summary;

	[FieldOffset(80)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference Itemised;

}
