namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AfflictionStartDialogue
{
	[FieldOffset(0)]
	[ReferenceTable("WorldAreas")]
	public TableReference WorldAreasKey;

	[FieldOffset(16)]
	[ReferenceTable("NPCTextAudio")]
	public TableReference NPCTextAudioKey;

	[FieldOffset(32)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk002;

}
