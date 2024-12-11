using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Colours
{
	[FieldOffset(0)]
	public TString Item;

	[FieldOffset(8)]
	public int Red;

	[FieldOffset(12)]
	public int Green;

	[FieldOffset(16)]
	public int Blue;

	[FieldOffset(20)]
	public TString RgbCode;

}
