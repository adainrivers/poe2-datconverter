namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ExpeditionTerrainFeatures
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("ExtraTerrainFeatures")]
	public TableReference ExtraFeature;

	[FieldOffset(24)]
	[ReferenceTable("ExpeditionFactions")]
	public TableReference ExpeditionFaction;

	[FieldOffset(40)]
	public int MinLevel;

	[FieldOffset(44)]
	public int MaxLevel;

	[FieldOffset(48)]
	public int Unk005;

	[FieldOffset(52)]
	[ReferenceTable("WorldAreas")]
	public TableReference Area;

	[FieldOffset(68)]
	[ReferenceTable("ExpeditionAreas")]
	[ElementType(typeof(TableReference))]
	public ArrayReference ExpeditionAreas;

	[FieldOffset(84)]
	public int Unk008;

	[FieldOffset(88)]
	public TBool Unk009;

	[FieldOffset(89)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference UnearthAchievements;

}
