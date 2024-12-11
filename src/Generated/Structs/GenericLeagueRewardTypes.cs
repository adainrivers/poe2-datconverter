using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct GenericLeagueRewardTypes
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public int MinLevel;

	[FieldOffset(12)]
	public int MaxLevel;

}
