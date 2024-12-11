using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MapInhabitants
{
	[FieldOffset(0)]
	[ReferenceTable("Stats")]
	public TRef StatsKey;

	[FieldOffset(16)]
	[ReferenceTable("MonsterPacks")]
	[ElementType(typeof(TRef))]
	public TArray MonsterPacksKeys;

}
