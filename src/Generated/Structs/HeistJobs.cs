namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HeistJobs
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference Name;

	[FieldOffset(16)]
	public StringReference RequiredSkillIcon;

	[FieldOffset(24)]
	public StringReference SkillIcon;

	[FieldOffset(32)]
	public float Unk004;

	[FieldOffset(36)]
	public int Unk005;

	[FieldOffset(40)]
	public StringReference MapIcon;

	[FieldOffset(48)]
	[ReferenceTable("Stats")]
	public TableReference Level_StatsKey;

	[FieldOffset(64)]
	[ReferenceTable("Stats")]
	public TableReference Alert_StatsKey;

	[FieldOffset(80)]
	[ReferenceTable("Stats")]
	public TableReference Alarm_StatsKey;

	[FieldOffset(96)]
	[ReferenceTable("Stats")]
	public TableReference Cost_StatsKey;

	[FieldOffset(112)]
	[ReferenceTable("Stats")]
	public TableReference ExperienceGain_StatsKey;

	[FieldOffset(128)]
	public StringReference ConsoleBlueprintLegend;

	[FieldOffset(136)]
	public StringReference Description;

}
