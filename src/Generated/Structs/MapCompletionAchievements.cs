namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MapCompletionAchievements
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("MapStatConditions")]
	[ElementType(typeof(TableReference))]
	public ArrayReference MapStatConditionsKeys;

	[FieldOffset(24)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TableReference))]
	public ArrayReference StatsKeys;

	[FieldOffset(40)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference AchievementItemsKeys;

	[FieldOffset(56)]
	[ReferenceTable("MapTierAchievements")]
	[ElementType(typeof(TableReference))]
	public ArrayReference MapTierAchievementsKeys;

	[FieldOffset(72)]
	public TBool Unk005;

	[FieldOffset(73)]
	[ReferenceTable("WorldAreas")]
	[ElementType(typeof(TableReference))]
	public ArrayReference WorldAreasKeys;

	[FieldOffset(89)]
	[ElementType(typeof(int))]
	public ArrayReference Unk007;

}
