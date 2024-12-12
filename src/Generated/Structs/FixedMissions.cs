namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct FixedMissions
{
	[FieldOffset(0)]
	[ReferenceTable("QuestAchievements")]
	public TableReference Unk000;

	[FieldOffset(16)]
	public TableReference Unk001;

	[FieldOffset(32)]
	[ElementType(typeof(int))]
	public ArrayReference Unk002;

	[FieldOffset(48)]
	public TableReference Unk003;

	[FieldOffset(64)]
	public TableReference Unk004;

	[FieldOffset(80)]
	public int Unk005;

	[FieldOffset(84)]
	public int Unk006;

	[FieldOffset(88)]
	public int Unk007;

}
