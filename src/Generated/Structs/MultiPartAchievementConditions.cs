namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MultiPartAchievementConditions
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("MultiPartAchievements")]
	public TableReference MultiPartAchievementsKey1;

	[FieldOffset(24)]
	[ReferenceTable("MultiPartAchievements")]
	public TableReference MultiPartAchievementsKey2;

	[FieldOffset(40)]
	public int Unk003;

	[FieldOffset(44)]
	public int Unk004;

}
