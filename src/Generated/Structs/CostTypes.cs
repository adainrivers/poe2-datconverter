using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct CostTypes
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("Stats")]
	public TRef StatsKey;

	[FieldOffset(24)]
	public TString FormatText;

	[FieldOffset(32)]
	public int Unk003;

}
