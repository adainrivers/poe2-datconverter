namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AchievementItems
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public int Unk001;

	[FieldOffset(12)]
	public int Unk002;

	[FieldOffset(16)]
	public StringReference Name;

	[FieldOffset(24)]
	public int CompletionsRequired;

	[FieldOffset(28)]
	[ReferenceTable("Achievements")]
	public TableReference AchievementsKey;

	[FieldOffset(44)]
	public TBool Unk006;

	[FieldOffset(45)]
	public TBool Unk007;

	[FieldOffset(46)]
	public TBool Unk008;

	[FieldOffset(47)]
	public TBool Unk009;

}
