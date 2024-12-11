using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct QuestRewards
{
	[FieldOffset(0)]
	[ReferenceTable("QuestRewardOffers")]
	public TRef RewardOffer;

	[FieldOffset(16)]
	public int Unk001;

	[FieldOffset(20)]
	public int Unk002;

	[FieldOffset(24)]
	[ReferenceTable("Characters")]
	[ElementType(typeof(TRef))]
	public TArray Characters;

	[FieldOffset(40)]
	[ReferenceTable("BaseItemTypes")]
	public TRef Reward;

	[FieldOffset(56)]
	public int RewardLevel;

	[FieldOffset(60)]
	public TRef Unk006;

	[FieldOffset(76)]
	public int Unk007;

	[FieldOffset(80)]
	public TString Unk008;

	[FieldOffset(88)]
	[ElementType(typeof(int))]
	public TArray Unk009;

	[FieldOffset(104)]
	public int RewardStack;

	[FieldOffset(108)]
	public TBool Unk011;

	[FieldOffset(109)]
	public TBool Unk012;

	[FieldOffset(110)]
	[ElementType(typeof(int))]
	public TArray Unk013;

	[FieldOffset(126)]
	public int Unk014;

	[FieldOffset(130)]
	public int Unk015;

	[FieldOffset(134)]
	[ElementType(typeof(int))]
	public TArray Unk016;

	[FieldOffset(150)]
	public int Unk017;

	[FieldOffset(154)]
	public TRef Unk018;

	[FieldOffset(170)]
	public int Unk019;

	[FieldOffset(174)]
	[ElementType(typeof(int))]
	public TArray Unk020;

}
