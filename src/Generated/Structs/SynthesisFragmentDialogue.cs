namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SynthesisFragmentDialogue
{
	[FieldOffset(0)]
	public TableReference Unk000;

	[FieldOffset(16)]
	[ReferenceTable("NPCTextAudio")]
	public TableReference NPCTextAudioKey1;

	[FieldOffset(32)]
	[ReferenceTable("NPCTextAudio")]
	public TableReference NPCTextAudioKey2;

	[FieldOffset(48)]
	[ReferenceTable("NPCTextAudio")]
	public TableReference NPCTextAudioKey3;

	[FieldOffset(64)]
	[ReferenceTable("NPCTextAudio")]
	public TableReference NPCTextAudioKey4;

	[FieldOffset(80)]
	[ReferenceTable("NPCTextAudio")]
	public TableReference NPCTextAudioKey5;

	[FieldOffset(96)]
	[ReferenceTable("NPCTextAudio")]
	public TableReference NPCTextAudioKey6;

}
