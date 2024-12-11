using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct LeagueFlag
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Image;

	[FieldOffset(16)]
	public bool IsHC;

	[FieldOffset(17)]
	public bool IsSSF;

	[FieldOffset(18)]
	public TString Banner;

	[FieldOffset(26)]
	public bool IsRuthless;

}
