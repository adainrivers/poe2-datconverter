using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MapStatConditions
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("Stats")]
	public TRef StatsKey;

	[FieldOffset(24)]
	public TBool Unk002;

	[FieldOffset(25)]
	public int StatMin;

	[FieldOffset(29)]
	public int StatMax;

	[FieldOffset(33)]
	public TBool Unk005;

}
