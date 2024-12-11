using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct DelveLevelScaling
{
	[FieldOffset(0)]
	public int Depth;

	[FieldOffset(4)]
	public int MonsterLevel;

	[FieldOffset(8)]
	public int Unk002;

	[FieldOffset(12)]
	public int SulphiteCost;

	[FieldOffset(16)]
	public int MonsterLevel2;

	[FieldOffset(20)]
	public int MoreMonsterDamage;

	[FieldOffset(24)]
	public int MoreMonsterLife;

	[FieldOffset(28)]
	public int DarknessResistance;

	[FieldOffset(32)]
	public int LightRadius;

	[FieldOffset(36)]
	public int Unk009;

	[FieldOffset(40)]
	public int Unk010;

	[FieldOffset(44)]
	public int Unk011;

	[FieldOffset(48)]
	public int Unk012;

	[FieldOffset(52)]
	public int Unk013;

	[FieldOffset(56)]
	public int Unk014;

}
