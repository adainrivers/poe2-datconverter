namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct IncursionRoomBossFightEvents
{
	[FieldOffset(0)]
	[ReferenceTable("IncursionRooms")]
	public TableReference Room;

	[FieldOffset(16)]
	public StringReference Unk001;

	[FieldOffset(24)]
	public StringReference Unk002;

	[FieldOffset(32)]
	public StringReference Unk003;

	[FieldOffset(40)]
	public StringReference Unk004;

	[FieldOffset(48)]
	public StringReference Unk005;

	[FieldOffset(56)]
	public TableReference Unk006;

}
