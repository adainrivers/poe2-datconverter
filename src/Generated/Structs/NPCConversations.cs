namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct NPCConversations
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("DialogueEvent")]
	public TableReference DialogueEvent;

	[FieldOffset(24)]
	[ReferenceTable("NPCTextAudio")]
	[ElementType(typeof(TableReference))]
	public ArrayReference NPCTextAudioKeys;

	[FieldOffset(40)]
	[ElementType(typeof(int))]
	public ArrayReference Unk003;

	[FieldOffset(56)]
	public int Unk004;

}
