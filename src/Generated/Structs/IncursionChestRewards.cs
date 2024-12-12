namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct IncursionChestRewards
{
	[FieldOffset(0)]
	[ReferenceTable("IncursionRooms")]
	public TableReference IncursionRoomsKey;

	[FieldOffset(16)]
	[ReferenceTable("IncursionChests")]
	[ElementType(typeof(TableReference))]
	public ArrayReference IncursionChestsKeys;

	[FieldOffset(32)]
	public StringReference ChestMarkerMetadata;

	[FieldOffset(40)]
	public int Unk003;

	[FieldOffset(44)]
	public int Unk004;

	[FieldOffset(48)]
	public int Unk005;

	[FieldOffset(52)]
	public int Unk006;

	[FieldOffset(56)]
	public int Unk007;

	[FieldOffset(60)]
	public int Unk008;

	[FieldOffset(64)]
	public int Unk009;

	[FieldOffset(68)]
	public int Unk010;

	[FieldOffset(72)]
	public int Unk011;

}
