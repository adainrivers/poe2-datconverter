namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MapPurchaseCosts
{
	[FieldOffset(0)]
	public int Tier;

	[FieldOffset(4)]
	[ReferenceTable("ItemCosts")]
	public TableReference Cost;

	[FieldOffset(20)]
	public TableReference Unk002;

}
