using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MonsterTypes
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public int Unk001;

	[FieldOffset(12)]
	public bool IsSummoned;

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
	public TRef MonsterResistancesKey;

	[FieldOffset(45)]
	public bool IsLargeAbyssMonster;

	[FieldOffset(46)]
	public bool IsSmallAbyssMonster;

	[FieldOffset(47)]
	public bool Unk010;

}
