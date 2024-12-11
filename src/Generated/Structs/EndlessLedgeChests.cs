using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct EndlessLedgeChests
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("WorldAreas")]
	public TRef WorldAreasKey;

	[FieldOffset(24)]
	[ReferenceTable("BaseItemTypes")]
	[ElementType(typeof(TRef))]
	public TArray BaseItemTypesKeys;

	[FieldOffset(40)]
	public TString SocketColour;

}
