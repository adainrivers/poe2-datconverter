namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MonsterSpawnerGroupsPerLevel
{
	[FieldOffset(0)]
	[ReferenceTable("MonsterSpawnerGroups")]
	public TableReference MonsterSpawnerGroupsKey;

	[FieldOffset(16)]
	public int MinLevel;

	[FieldOffset(20)]
	public int Unk002;

	[FieldOffset(24)]
	public int Unk003;

	[FieldOffset(28)]
	public int Unk004;

}
