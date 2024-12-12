namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ItemCostPerLevel
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference Contract_BaseItemTypesKey;

	[FieldOffset(16)]
	public int Level;

	[FieldOffset(20)]
	[ReferenceTable("ItemCosts")]
	public TableReference Cost;

	[FieldOffset(36)]
	[ReferenceTable("ItemCosts")]
	public TableReference CostHardmode;

}
