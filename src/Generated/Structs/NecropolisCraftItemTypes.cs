namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct NecropolisCraftItemTypes
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference ExorciseIcon;

	[FieldOffset(16)]
	public StringReference Name;

	[FieldOffset(24)]
	public int Unk003;

	[FieldOffset(28)]
	public StringReference IllustratuionIcon;

	[FieldOffset(36)]
	[ReferenceTable("NPCTextAudio")]
	public TableReference TextAudioLong;

	[FieldOffset(52)]
	[ReferenceTable("AchievementItems")]
	public TableReference Achievements;

	[FieldOffset(68)]
	[ReferenceTable("NPCTextAudio")]
	public TableReference TextAudioShort;

	[FieldOffset(84)]
	public TableReference Unk008;

}
