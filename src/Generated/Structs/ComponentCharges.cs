using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ComponentCharges
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TString BaseItemTypesKey;

	[FieldOffset(8)]
	public int MaxCharges;

	[FieldOffset(12)]
	public int PerCharge;

	[FieldOffset(16)]
	public int MaxCharges2;

	[FieldOffset(20)]
	public int PerCharge2;

}
