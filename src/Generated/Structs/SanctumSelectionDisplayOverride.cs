using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SanctumSelectionDisplayOverride
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Reward;

	[FieldOffset(16)]
	public TString Icon;

	[FieldOffset(24)]
	public TString Downside;

	[FieldOffset(32)]
	[ReferenceTable("BaseItemTypes")]
	public TRef Item;

	[FieldOffset(48)]
	public int Count;

	[FieldOffset(52)]
	[ReferenceTable("SanctumDeferredRewardCategories")]
	public TRef RewardCategory;

}
