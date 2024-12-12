namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct NecropolisCraftingMods
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public int Unk001;

	[FieldOffset(12)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Stats;

	[FieldOffset(28)]
	[ElementType(typeof(int))]
	public ArrayReference StatsValues;

	[FieldOffset(44)]
	[ReferenceTable("NecropolisCraftItemTypes")]
	public TableReference CraftingItemType;

	[FieldOffset(60)]
	public int Unk005;

	[FieldOffset(64)]
	public TBool CorpsesNotConsumed;

	[FieldOffset(65)]
	[ReferenceTable("NecropolisCraftItemTypes")]
	[ElementType(typeof(TableReference))]
	public ArrayReference CraftingItemTypes;

	[FieldOffset(81)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Achievements;

	[FieldOffset(97)]
	public int MatchingMonsters;

}
