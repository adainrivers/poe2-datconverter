using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AtlasExileBossArenas
{
	[FieldOffset(0)]
	[ReferenceTable("AtlasExiles")]
	public TRef Conqueror;

	[FieldOffset(16)]
	[ReferenceTable("WorldAreas")]
	public TRef WorldArea;

}
