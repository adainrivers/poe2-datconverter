namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SessionQuestFlags
{
	[FieldOffset(0)]
	[ReferenceTable("QuestFlags")]
	public TableReference QuestFlag;

}
