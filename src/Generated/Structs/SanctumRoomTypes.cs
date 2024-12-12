namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SanctumRoomTypes
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public TBool Unk001;

	[FieldOffset(9)]
	public TBool Unk002;

	[FieldOffset(10)]
	public TableReference Unk003;

	[FieldOffset(26)]
	public TableReference Unk004;

	[FieldOffset(42)]
	public TBool Unk005;

	[FieldOffset(43)]
	public StringReference Icon;

	[FieldOffset(51)]
	public TBool Unk007;

	[FieldOffset(52)]
	public StringReference Description;

	[FieldOffset(60)]
	[ElementType(typeof(StringReference))]
	public ArrayReference Unk009;

	[FieldOffset(76)]
	[ReferenceTable("SanctumRooms")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Rooms;

	[FieldOffset(92)]
	public StringReference Unk011;

	[FieldOffset(100)]
	public TBool Unk012;

}
