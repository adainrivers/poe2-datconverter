using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct RunicCircles
{
	[FieldOffset(0)]
	public TString Unk000;

	[FieldOffset(8)]
	public int Unk001;

	[FieldOffset(12)]
	[ElementType(typeof(int))]
	public TArray Unk002;

	[FieldOffset(28)]
	public int Unk003;

}
