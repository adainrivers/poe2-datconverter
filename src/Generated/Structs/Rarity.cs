using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Rarity
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public int MinMods;

	[FieldOffset(12)]
	public int MaxMods;

	[FieldOffset(16)]
	public int Unk003;

	[FieldOffset(20)]
	public int MaxPrefix;

	[FieldOffset(24)]
	public int Unk005;

	[FieldOffset(28)]
	public int MaxSuffix;

	[FieldOffset(32)]
	public TString Color;

	[FieldOffset(40)]
	public TString Text;

}
