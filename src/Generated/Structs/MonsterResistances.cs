using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MonsterResistances
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public int FireNormal;

	[FieldOffset(12)]
	public int ColdNormal;

	[FieldOffset(16)]
	public int LightningNormal;

	[FieldOffset(20)]
	public int ChaosNormal;

	[FieldOffset(24)]
	public int FireCruel;

	[FieldOffset(28)]
	public int ColdCruel;

	[FieldOffset(32)]
	public int LightningCruel;

	[FieldOffset(36)]
	public int ChaosCruel;

	[FieldOffset(40)]
	public int FireMerciless;

	[FieldOffset(44)]
	public int ColdMerciless;

	[FieldOffset(48)]
	public int LightningMerciless;

	[FieldOffset(52)]
	public int ChaosMerciless;

}
