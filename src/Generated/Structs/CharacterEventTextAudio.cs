namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct CharacterEventTextAudio
{
	[FieldOffset(0)]
	[ReferenceTable("CharacterAudioEvents")]
	public TableReference Event;

	[FieldOffset(16)]
	[ReferenceTable("Characters")]
	public TableReference Character;

	[FieldOffset(32)]
	[ReferenceTable("CharacterTextAudio")]
	[ElementType(typeof(TableReference))]
	public ArrayReference TextAudio;

}
