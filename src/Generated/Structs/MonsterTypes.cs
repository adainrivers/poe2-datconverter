namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MonsterTypes
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public int Unk001;

	[FieldOffset(12)]
	public TBool IsSummoned;

	[FieldOffset(13)]
	public int Armour;

	[FieldOffset(17)]
	public int Evasion;

	[FieldOffset(21)]
	public int EnergyShieldFromLife;

	[FieldOffset(25)]
	public int DamageSpread;

	[FieldOffset(29)]
	[ReferenceTable("MonsterResistances")]
	public TableReference MonsterResistancesKey;

	[FieldOffset(45)]
	public TBool IsLargeAbyssMonster;

	[FieldOffset(46)]
	public TBool IsSmallAbyssMonster;

	[FieldOffset(47)]
	public TBool Unk010;

}
