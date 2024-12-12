namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HarvestSeedItems
{
	[FieldOffset(0)]
	public int Id;

	[FieldOffset(4)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference BaseItem;

	[FieldOffset(20)]
	[ReferenceTable("Stats")]
	public TableReference DropStat;

}
