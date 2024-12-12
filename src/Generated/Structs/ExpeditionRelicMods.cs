namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ExpeditionRelicMods
{
	[FieldOffset(0)]
	[ReferenceTable("Mods")]
	public TableReference Mod;

	[FieldOffset(16)]
	[ReferenceTable("ExpeditionRelicModCategories")]
	[EnumName("ExpeditionRelicModCategories")]
	[ElementType(typeof(TEnum))]
	public ArrayReference Categories;

	[FieldOffset(32)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference DestroyAchievements;

}
