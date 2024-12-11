using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SanctumDeferredRewards
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString DeferralIcon;

	[FieldOffset(16)]
	[ReferenceTable("SanctumPersistentEffectCategories")]
	public TRef DeferralCategory;

	[FieldOffset(32)]
	[ReferenceTable("SanctumDeferredRewardCategories")]
	public TRef RewardCategory;

	[FieldOffset(48)]
	public int Count;

}
