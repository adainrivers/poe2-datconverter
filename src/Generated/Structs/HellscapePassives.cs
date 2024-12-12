namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HellscapePassives
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference Name;

	[FieldOffset(16)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Stats;

	[FieldOffset(32)]
	[ElementType(typeof(int))]
	public ArrayReference StatsValues;

	[FieldOffset(48)]
	public int Points;

	[FieldOffset(52)]
	public int HASH16;

	[FieldOffset(56)]
	public StringReference Icon;

	[FieldOffset(64)]
	public StringReference IconMaxed;

	[FieldOffset(72)]
	[ReferenceTable("SoundEffects")]
	public TableReference SoundEffect;

	[FieldOffset(88)]
	public int Unk009;

	[FieldOffset(92)]
	[ReferenceTable("Quest")]
	public TableReference Quest;

}
