namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SpawnAdditionalChestsOrClusters
{
	[FieldOffset(0)]
	[ReferenceTable("Stats")]
	public TableReference StatsKey;

	[FieldOffset(16)]
	[ReferenceTable("Chests")]
	public TableReference ChestsKey;

	[FieldOffset(32)]
	[ReferenceTable("ChestClusters")]
	public TableReference ChestClustersKey;

}
