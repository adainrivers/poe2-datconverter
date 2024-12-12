namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MapInhabitants
{
	[FieldOffset(0)]
	[ReferenceTable("Stats")]
	public TableReference StatsKey;

	[FieldOffset(16)]
	[ReferenceTable("MonsterPacks")]
	[ElementType(typeof(TableReference))]
	public ArrayReference MonsterPacksKeys;

}
