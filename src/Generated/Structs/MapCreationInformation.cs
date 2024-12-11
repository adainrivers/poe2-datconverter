using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MapCreationInformation
{
	[FieldOffset(0)]
	[ReferenceTable("Maps")]
	public TRef MapsKey;

	[FieldOffset(16)]
	public int Tier;

}
