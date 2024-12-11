using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AdditionalLifeScaling
{
	[FieldOffset(0)]
	public int IntId;

	[FieldOffset(4)]
	public TString ID;

	[FieldOffset(12)]
	public TString DatFile;

	[FieldOffset(20)]
	public bool Unk003;

}
