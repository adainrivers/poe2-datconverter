using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ItemCostPerLevel
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TRef Contract_BaseItemTypesKey;

	[FieldOffset(16)]
	public int Level;

	[FieldOffset(20)]
	[ReferenceTable("ItemCosts")]
	public TRef Cost;

	[FieldOffset(36)]
	[ReferenceTable("ItemCosts")]
	public TRef CostHardmode;

}
