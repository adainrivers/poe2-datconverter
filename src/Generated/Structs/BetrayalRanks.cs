using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BetrayalRanks
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Text;

	[FieldOffset(16)]
	public int Level;

	[FieldOffset(20)]
	public TString RankImage;

}
