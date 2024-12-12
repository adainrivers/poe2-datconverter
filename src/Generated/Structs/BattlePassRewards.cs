namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BattlePassRewards
{
	[FieldOffset(0)]
	[ReferenceTable("BattlePasses")]
	public TableReference BattlePass;

	[FieldOffset(16)]
	public int RewardTier;

	[FieldOffset(20)]
	public int Unk002;

	[FieldOffset(24)]
	public int Unk003;

	[FieldOffset(28)]
	public TBool Unk004;

	[FieldOffset(29)]
	public StringReference Id;

	[FieldOffset(37)]
	[ReferenceTable("BaseItemTypes")]
	[ElementType(typeof(TableReference))]
	public ArrayReference RewardedMTX;

	[FieldOffset(53)]
	public int Unk007;

	[FieldOffset(57)]
	public StringReference RewardDescription;

	[FieldOffset(65)]
	public StringReference Unk009;

	[FieldOffset(73)]
	public int Unk010;

	[FieldOffset(77)]
	public int Unk011;

	[FieldOffset(81)]
	public TBool Unk012;

	[FieldOffset(82)]
	public StringReference RewardTitle;

	[FieldOffset(90)]
	public TableReference Unk014;

	[FieldOffset(106)]
	public TBool Unk015;

	[FieldOffset(107)]
	public int Unk016;

	[FieldOffset(111)]
	public int Unk017;

	[FieldOffset(115)]
	public int Unk018;

	[FieldOffset(119)]
	public int Unk019;

	[FieldOffset(123)]
	public int Unk020;

	[FieldOffset(127)]
	public int Unk021;

	[FieldOffset(131)]
	public int Unk022;

	[FieldOffset(135)]
	public int Unk023;

	[FieldOffset(139)]
	public TBool Unk024;

	[FieldOffset(140)]
	public TBool Unk025;

	[FieldOffset(141)]
	public TBool Unk026;

}
