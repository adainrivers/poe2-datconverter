using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ComponentAttributeRequirements
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TString BaseItemTypesKey;

	[FieldOffset(8)]
	public int ReqStr;

	[FieldOffset(12)]
	public int ReqDex;

	[FieldOffset(16)]
	public int ReqInt;

}
