namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct LakeRoomCompletion
{
	[FieldOffset(0)]
	[ReferenceTable("LakeRooms")]
	public TableReference Room;

	[FieldOffset(16)]
	public int Unk001;

	[FieldOffset(20)]
	public int Unk002;

	[FieldOffset(24)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Achievements;

	[FieldOffset(40)]
	[ElementType(typeof(int))]
	public ArrayReference Unk004;

	[FieldOffset(56)]
	[ElementType(typeof(int))]
	public ArrayReference Unk005;

	[FieldOffset(72)]
	public int Unk006;

}
