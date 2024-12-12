namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SynthesisAreas
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public int MinLevel;

	[FieldOffset(12)]
	public int MaxLevel;

	[FieldOffset(16)]
	public int Weight;

	[FieldOffset(20)]
	[ReferenceTable("Topologies")]
	public TableReference TopologiesKey;

	[FieldOffset(36)]
	[ReferenceTable("MonsterPacks")]
	[ElementType(typeof(TableReference))]
	public ArrayReference MonsterPacksKeys;

	[FieldOffset(52)]
	public StringReference ArtFile;

	[FieldOffset(60)]
	public StringReference Name;

	[FieldOffset(68)]
	[ReferenceTable("SynthesisAreaSize")]
	public TableReference SynthesisAreaSizeKey;

	[FieldOffset(84)]
	[ReferenceTable("AchievementItems")]
	public TableReference AchievementItemsKey;

}
