using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SpawnAdditionalChestsOrClusters
{
	[FieldOffset(0)]
	[ReferenceTable("Stats")]
	public TRef StatsKey;

	[FieldOffset(16)]
	[ReferenceTable("Chests")]
	public TRef ChestsKey;

	[FieldOffset(32)]
	[ReferenceTable("ChestClusters")]
	public TRef ChestClustersKey;

}
