using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MapStashUniqueMapInfo
{
	[FieldOffset(0)]
	[ReferenceTable("UniqueMaps")]
	public TRef UniqueMap;

	[FieldOffset(16)]
	[ReferenceTable("BaseItemTypes")]
	public TRef BaseItem;

}
