namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct QuestTrackerGroup
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference Name;

	[FieldOffset(16)]
	[ReferenceTable("QuestType")]
	public TableReference QuestType;

}
