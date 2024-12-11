using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct QuestRewardOffers
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("Quest")]
	public TRef QuestKey;

	[FieldOffset(24)]
	[ReferenceTable("QuestFlags")]
	public TRef QuestFlag;

	[FieldOffset(40)]
	public int Unk003;

	[FieldOffset(44)]
	[ReferenceTable("ClientStrings")]
	public TRef RewardWindowTake;

	[FieldOffset(60)]
	public TBool Unk005;

	[FieldOffset(61)]
	public TBool Unk006;

	[FieldOffset(62)]
	[ReferenceTable("ClientStrings")]
	public TRef RewardWindowTitle;

	[FieldOffset(78)]
	public TBool Unk008;

	[FieldOffset(79)]
	public TBool Unk009;

	[FieldOffset(80)]
	public TBool Unk010;

	[FieldOffset(81)]
	public TBool Unk011;

	[FieldOffset(82)]
	public TRef Unk012;

}
