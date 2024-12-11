using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Topologies
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString DGRFile;

	[FieldOffset(16)]
	public int Unk002;

	[FieldOffset(20)]
	public int Unk003;

	[FieldOffset(24)]
	public int Unk004;

}
