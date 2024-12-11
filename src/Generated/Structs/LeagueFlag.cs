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
	public TBool IsHC;

	[FieldOffset(17)]
	public TBool IsSSF;

	[FieldOffset(18)]
	public TString Banner;

	[FieldOffset(26)]
	public TBool IsRuthless;

}
