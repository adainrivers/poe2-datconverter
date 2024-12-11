using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct GameConstants
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public int Value;

	[FieldOffset(12)]
	public int Unk002;

}
