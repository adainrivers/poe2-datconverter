namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BlightCraftingItems
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference Oil;

	[FieldOffset(16)]
	public int Tier;

	[FieldOffset(20)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Achievements;

	[FieldOffset(36)]
	public int UseType;

	[FieldOffset(40)]
	public StringReference NameShort;

}
