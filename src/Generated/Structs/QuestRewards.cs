using System;

namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct QuestRewards
{
	[FieldOffset(0)]
	[ReferenceTable("QuestRewardOffers")]
	public TableReference RewardOffer;

	[FieldOffset(32)]
	public long UnkLong001;

    [FieldOffset(40)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference Reward;

	[FieldOffset(56)]
	public int RewardLevel;

    [FieldOffset(60)]
    public TableReference SomeRef01;

    [FieldOffset(76)]
    public int UnkInt002;

    [FieldOffset(80)]
    public long UnkLong003;

	[FieldOffset(88)]
    public long UnkLong004;

    [FieldOffset(96)]
    public long UnkLong005;


    [FieldOffset(104)]
	public int RewardStack;

    [FieldOffset(108)]
    public int UnkInt006;

    [FieldOffset(112)]
    public int UnkInt007;

    [FieldOffset(116)]
    public short UnkShort008;

    [FieldOffset(118)]
    public long UnkLong009;

    [FieldOffset(126)]
    public long UnkLong010;

    [FieldOffset(134)]
    public long UnkLong011;

    [FieldOffset(142)]
    public long UnkLong012;

    [FieldOffset(150)]
    public int UnkInt013;

    [FieldOffset(154)]
    public TableReference SomeRef02;

    [FieldOffset(170)]
    public long UnkLong014;

    [FieldOffset(178)]
    public int UnkInt015;

    [FieldOffset(182)]
    public long UnkLong016;

    [FieldOffset(190)]
    public int UnkInt017;

    [FieldOffset(194)]
    public TBool Unk018;
}
