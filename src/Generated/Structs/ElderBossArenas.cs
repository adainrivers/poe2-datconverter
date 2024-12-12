namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ElderBossArenas
{
	[FieldOffset(0)]
	[ReferenceTable("WorldAreas")]
	public TableReference WorldAreasKey;

	[FieldOffset(16)]
	public int Unk001;

	[FieldOffset(20)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference AchievementItemsKeys;

}
