namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HarvestCraftOptions
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference Text;

	[FieldOffset(16)]
	[ReferenceTable("HarvestCraftTiers")]
	public TableReference Tier;

	[FieldOffset(32)]
	public StringReference Command;

	[FieldOffset(40)]
	public StringReference Parameters;

	[FieldOffset(48)]
	[ElementType(typeof(int))]
	public ArrayReference Unk005;

	[FieldOffset(64)]
	public short HASH16;

	[FieldOffset(66)]
	public StringReference Description;

	[FieldOffset(74)]
	public TBool IsEnchant;

	[FieldOffset(75)]
	public int LifeforceType;

	[FieldOffset(79)]
	public int LifeforceCost;

	[FieldOffset(83)]
	public int SacredCost;

	[FieldOffset(87)]
	public TBool Unk012;

	[FieldOffset(88)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Achievements;

	[FieldOffset(104)]
	public int Unk014;

}
