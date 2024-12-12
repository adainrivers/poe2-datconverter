namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct CharacterAudioEvents
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("QuestFlags")]
	public TableReference Event;

	[FieldOffset(24)]
	public int Unk002;

	[FieldOffset(28)]
	public int Unk003;

	[FieldOffset(32)]
	[ReferenceTable("CharacterTextAudio")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Goddess_CharacterTextAudioKeys;

	[FieldOffset(48)]
	[ReferenceTable("CharacterTextAudio")]
	[ElementType(typeof(TableReference))]
	public ArrayReference JackTheAxe_CharacterTextAudioKeys;

	[FieldOffset(64)]
	public TBool Unk006;

	[FieldOffset(65)]
	public TBool Unk007;

}
