namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SanctumDeferredRewards
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference DeferralIcon;

	[FieldOffset(16)]
	[ReferenceTable("SanctumPersistentEffectCategories")]
	public TableReference DeferralCategory;

	[FieldOffset(32)]
	[ReferenceTable("SanctumDeferredRewardCategories")]
	public TableReference RewardCategory;

	[FieldOffset(48)]
	public int Count;

}
