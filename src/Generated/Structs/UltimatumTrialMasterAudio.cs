namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct UltimatumTrialMasterAudio
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public int Variant;

	[FieldOffset(12)]
	public int Unk002;

	[FieldOffset(16)]
	public int Unk003;

	[FieldOffset(20)]
	[ReferenceTable("NPCTextAudio")]
	public TableReference TextAudio;

	[FieldOffset(36)]
	public int RoundsMin;

	[FieldOffset(40)]
	public int RoundsMax;

}
