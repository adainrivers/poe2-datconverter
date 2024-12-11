using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HeistNPCStats
{
	[FieldOffset(0)]
	[ReferenceTable("Stats")]
	public TRef StatsKey;

	[FieldOffset(16)]
	public bool Unk001;

	[FieldOffset(17)]
	public bool Unk002;

	[FieldOffset(18)]
	public bool Unk003;

	[FieldOffset(19)]
	public bool Unk004;

}
