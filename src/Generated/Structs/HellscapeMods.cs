namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HellscapeMods
{
	[FieldOffset(0)]
	[ReferenceTable("Mods")]
	public TableReference Mod;

	[FieldOffset(16)]
	[ElementType(typeof(int))]
	public ArrayReference TiersWhitelist;

	[FieldOffset(32)]
	[ReferenceTable("AchievementItems")]
	public TableReference TransformAchievement;

	[FieldOffset(48)]
	[ReferenceTable("ModFamily")]
	[ElementType(typeof(TableReference))]
	public ArrayReference ModFamilies;

}
