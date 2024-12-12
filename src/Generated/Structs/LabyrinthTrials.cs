namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct LabyrinthTrials
{
	[FieldOffset(0)]
	[ReferenceTable("WorldAreas")]
	public TableReference WorldAreas;

	[FieldOffset(16)]
	public int Unk001;

	[FieldOffset(20)]
	public int Unk002;

	[FieldOffset(24)]
	public int Unk003;

	[FieldOffset(28)]
	[ReferenceTable("NPCTextAudio")]
	public TableReference NPCTextAudioKey;

	[FieldOffset(44)]
	public StringReference Unk005;

	[FieldOffset(52)]
	public StringReference Unk006;

	[FieldOffset(60)]
	public int Unk007;

	[FieldOffset(64)]
	public int Unk008;

	[FieldOffset(68)]
	public int Unk009;

	[FieldOffset(72)]
	public int Unk010;

}
