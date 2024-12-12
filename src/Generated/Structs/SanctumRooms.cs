namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SanctumRooms
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference ArmFile;

	[FieldOffset(16)]
	[ReferenceTable("SanctumRoomTypes")]
	public TableReference RoomType;

	[FieldOffset(32)]
	public StringReference Script;

	[FieldOffset(40)]
	[ReferenceTable("SanctumFloors")]
	public TableReference Floor;

	[FieldOffset(56)]
	[ReferenceTable("WorldAreas")]
	public TableReference Area;

}
