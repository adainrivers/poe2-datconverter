using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct DescentStarterChest
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("Characters")]
	public TRef CharactersKey;

	[FieldOffset(24)]
	[ReferenceTable("BaseItemTypes")]
	public TRef BaseItemTypesKey;

	[FieldOffset(40)]
	public TString SocketColours;

	[FieldOffset(48)]
	[ReferenceTable("WorldAreas")]
	public TRef WorldAreasKey;

}
