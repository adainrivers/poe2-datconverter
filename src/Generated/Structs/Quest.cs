namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Quest
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public int Act;

	[FieldOffset(12)]
	public StringReference Name;

	[FieldOffset(20)]
	public StringReference Icon_DDSFile;

	[FieldOffset(28)]
	public int QuestId;

	[FieldOffset(32)]
	public TBool Unk005;

	[FieldOffset(33)]
	[ReferenceTable("QuestType")]
	public TableReference Type;

	[FieldOffset(49)]
	[ElementType(typeof(int))]
	public ArrayReference Unk007;

	[FieldOffset(65)]
	public int Unk008;

	[FieldOffset(69)]
	[ReferenceTable("QuestTrackerGroup")]
	public TableReference TrackerGroup;

	[FieldOffset(85)]
	public TBool Unk010;

	[FieldOffset(86)]
	public TableReference Unk011;

}
