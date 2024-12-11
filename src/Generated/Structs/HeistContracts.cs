using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HeistContracts
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TRef BaseItemTypesKey;

	[FieldOffset(16)]
	[ReferenceTable("HeistAreas")]
	public TRef HeistAreasKey;

	[FieldOffset(32)]
	public int Unk002;

}
