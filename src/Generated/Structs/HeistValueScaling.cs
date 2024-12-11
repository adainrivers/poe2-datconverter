using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HeistValueScaling
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public float Unk001;

	[FieldOffset(12)]
	public float Unk002;

}
