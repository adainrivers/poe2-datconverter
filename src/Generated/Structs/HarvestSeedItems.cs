using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HarvestSeedItems
{
	[FieldOffset(0)]
	public int Id;

	[FieldOffset(4)]
	[ReferenceTable("BaseItemTypes")]
	public TRef BaseItem;

	[FieldOffset(20)]
	[ReferenceTable("Stats")]
	public TRef DropStat;

}
