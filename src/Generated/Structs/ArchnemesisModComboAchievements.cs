namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ArchnemesisModComboAchievements
{
	[FieldOffset(0)]
	[ReferenceTable("AchievementItems")]
	public TableReference Achievement;

	[FieldOffset(16)]
	[ReferenceTable("ArchnemesisMods")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Mods;

}
