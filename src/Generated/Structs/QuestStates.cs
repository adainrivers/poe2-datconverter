namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct QuestStates
{
	[FieldOffset(0)]
	[ReferenceTable("Quest")]
	public TableReference Quest;

	[FieldOffset(16)]
	public int Order;

	[FieldOffset(20)]
	[ReferenceTable("QuestFlags")]
	[ElementType(typeof(TableReference))]
	public ArrayReference FlagsPresent;

	[FieldOffset(36)]
	[ReferenceTable("QuestFlags")]
	[ElementType(typeof(TableReference))]
	public ArrayReference FlagsMissing;

	[FieldOffset(52)]
	public StringReference Text;

	[FieldOffset(60)]
	public TBool Unk005;

	[FieldOffset(61)]
	public StringReference Message;

	[FieldOffset(69)]
	[ReferenceTable("MapPins")]
	[ElementType(typeof(TableReference))]
	public ArrayReference MapPinsKeys1;

}
