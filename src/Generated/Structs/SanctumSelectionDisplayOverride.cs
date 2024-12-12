namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SanctumSelectionDisplayOverride
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference Reward;

	[FieldOffset(16)]
	public StringReference Icon;

	[FieldOffset(24)]
	public StringReference Downside;

	[FieldOffset(32)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference Item;

	[FieldOffset(48)]
	public int Count;

	[FieldOffset(52)]
	[ReferenceTable("SanctumDeferredRewardCategories")]
	public TableReference RewardCategory;

}
