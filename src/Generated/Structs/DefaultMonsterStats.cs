using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct DefaultMonsterStats
{
	[FieldOffset(0)]
	public TString DisplayLevel;

	[FieldOffset(8)]
	public float Damage;

	[FieldOffset(12)]
	public int Evasion;

	[FieldOffset(16)]
	public int Accuracy;

	[FieldOffset(20)]
	public int Life;

	[FieldOffset(24)]
	public int Experience;

	[FieldOffset(28)]
	public int AllyLife;

	[FieldOffset(32)]
	public int Unk007;

	[FieldOffset(36)]
	public int Difficulty;

	[FieldOffset(40)]
	public float Damage2;

	[FieldOffset(44)]
	public int Unk010;

	[FieldOffset(48)]
	public float Unk011;

	[FieldOffset(52)]
	public float Unk012;

	[FieldOffset(56)]
	public int Unk013;

	[FieldOffset(60)]
	public int Unk014;

	[FieldOffset(64)]
	public int Armour;

}
