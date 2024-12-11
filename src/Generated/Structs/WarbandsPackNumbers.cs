using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct WarbandsPackNumbers
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public int SpawnChance;

	[FieldOffset(12)]
	public int MinLevel;

	[FieldOffset(16)]
	public int MaxLevel;

	[FieldOffset(20)]
	public int Tier4Number;

	[FieldOffset(24)]
	public int Unk005;

	[FieldOffset(28)]
	public int Tier3Number;

	[FieldOffset(32)]
	public int Unk007;

	[FieldOffset(36)]
	public int Tier2Number;

	[FieldOffset(40)]
	public int Unk009;

	[FieldOffset(44)]
	public int Tier1Number;

}
