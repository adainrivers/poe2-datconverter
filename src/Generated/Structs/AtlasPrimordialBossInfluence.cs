namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AtlasPrimordialBossInfluence
{
	[FieldOffset(0)]
	[ReferenceTable("AtlasPrimordialBosses")]
	public TableReference Boss;

	[FieldOffset(16)]
	public int Progress;

	[FieldOffset(20)]
	public int MinMapTier;

	[FieldOffset(24)]
	public int Unk003;

	[FieldOffset(28)]
	public int Unk004;

	[FieldOffset(32)]
	public TableReference Unk005;

	[FieldOffset(48)]
	public float Unk006;

	[FieldOffset(52)]
	[ReferenceTable("QuestFlags")]
	public TableReference Unk007;

}
