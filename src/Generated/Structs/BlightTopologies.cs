using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BlightTopologies
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("BlightTopologyNodes")]
	public TRef BlightTopologyNodesKey;

	[FieldOffset(24)]
	public int Unk002;

	[FieldOffset(28)]
	public int Unk003;

	[FieldOffset(32)]
	public int Unk004;

	[FieldOffset(36)]
	public int Unk005;

	[FieldOffset(40)]
	public int Unk006;

	[FieldOffset(44)]
	public int Unk007;

	[FieldOffset(48)]
	public int Unk008;

}
