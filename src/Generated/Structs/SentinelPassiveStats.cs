using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SentinelPassiveStats
{
	[FieldOffset(0)]
	[ReferenceTable("Stats")]
	public TRef Unk000;

	[FieldOffset(16)]
	[ReferenceTable("Stats")]
	public TRef Unk001;

	[FieldOffset(32)]
	public int Unk002;

}
