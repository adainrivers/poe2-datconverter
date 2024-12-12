namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MultiPartAchievements
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public int Unk001;

	[FieldOffset(12)]
	[ReferenceTable("AchievementItems")]
	public TableReference AchievementItemsKey;

	[FieldOffset(28)]
	public int Unk003;

	[FieldOffset(32)]
	public TBool Unk004;

	[FieldOffset(33)]
	public TBool Unk005;

	[FieldOffset(34)]
	public int Unk006;

}
