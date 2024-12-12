namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MavenDialog
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("NPCTextAudio")]
	public TableReference TextAudioT1;

	[FieldOffset(24)]
	[ReferenceTable("NPCTextAudio")]
	public TableReference TextAudioT2;

	[FieldOffset(40)]
	[ReferenceTable("NPCTextAudio")]
	public TableReference TextAudioT3;

	[FieldOffset(56)]
	[ReferenceTable("NPCTextAudio")]
	public TableReference TextAudioT4;

	[FieldOffset(72)]
	[ReferenceTable("NPCTextAudio")]
	public TableReference TextAudioT5;

	[FieldOffset(88)]
	public TBool Unk006;

	[FieldOffset(89)]
	[ReferenceTable("NPCTextAudio")]
	public TableReference TextAudioT6;

}
