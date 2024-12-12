namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct LeagueProgressQuestFlags
{
	[FieldOffset(0)]
	[ReferenceTable("QuestFlags")]
	public TableReference QuestFlag;

	[FieldOffset(16)]
	[ReferenceTable("ClientStrings")]
	public TableReference CompletionString;

	[FieldOffset(32)]
	public StringReference Boss;

	[FieldOffset(40)]
	public TBool Unk003;

}
