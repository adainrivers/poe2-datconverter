namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SynthesisRewardTypes
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference Description;

	[FieldOffset(16)]
	public StringReference ArtFile;

	[FieldOffset(24)]
	[ReferenceTable("AchievementItems")]
	public TableReference AchievementItemsKey;

}
