using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct UltimatumItemisedRewards
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public int HASH16;

	[FieldOffset(12)]
	public TString RewardText;

	[FieldOffset(20)]
	[ReferenceTable("ItemVisualIdentity")]
	public TRef ItemVisualIdentityKey;

	[FieldOffset(36)]
	public int RewardType;

	[FieldOffset(40)]
	[ReferenceTable("BaseItemTypes")]
	public TRef SacrificeItem;

	[FieldOffset(56)]
	public int SacrificeAmount;

	[FieldOffset(60)]
	public TString SacrificeText;

	[FieldOffset(68)]
	public TBool Unk008;

	[FieldOffset(69)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TRef))]
	public TArray TrialMods;

}
