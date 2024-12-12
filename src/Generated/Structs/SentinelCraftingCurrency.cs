namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SentinelCraftingCurrency
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference Currency;

	[FieldOffset(16)]
	public int Type;

}
