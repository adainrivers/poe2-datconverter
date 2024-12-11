using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct StatsAffectingGeneration
{
	[FieldOffset(0)]
	[ReferenceTable("Stats")]
	public TRef Stat;

	[FieldOffset(16)]
	public int StatValue;

}
