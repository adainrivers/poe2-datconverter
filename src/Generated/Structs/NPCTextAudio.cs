namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct NPCTextAudio
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("Characters")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Characters;

	[FieldOffset(24)]
	public StringReference Text;

	[FieldOffset(32)]
	public StringReference Mono_AudioFile;

	[FieldOffset(40)]
	public StringReference Stereo_AudioFile;

	[FieldOffset(48)]
	public TBool HasStereo;

	[FieldOffset(49)]
	public TBool Unk006;

	[FieldOffset(50)]
	public StringReference Video;

	[FieldOffset(58)]
	public int Unk008;

	[FieldOffset(62)]
	public int Unk009;

	[FieldOffset(66)]
	public int Unk010;

	[FieldOffset(70)]
	[ReferenceTable("NPCs")]
	[ElementType(typeof(TableReference))]
	public ArrayReference NPCs;

	[FieldOffset(86)]
	public TableReference Unk012;

}
