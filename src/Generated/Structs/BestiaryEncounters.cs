namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BestiaryEncounters
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("MonsterPacks")]
	public TableReference MonsterPacksKey;

	[FieldOffset(24)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference MonsterVarietiesKey;

	[FieldOffset(40)]
	public StringReference MonsterSpawnerId;

}
