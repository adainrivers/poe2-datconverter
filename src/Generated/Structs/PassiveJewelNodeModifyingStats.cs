using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct PassiveJewelNodeModifyingStats
{
	[FieldOffset(0)]
	[ReferenceTable("Stats")]
	public TRef JwelStat;

	[FieldOffset(16)]
	[ReferenceTable("Stats")]
	public TRef Stat;

	[FieldOffset(32)]
	public TBool Unk002;

	[FieldOffset(33)]
	public TBool Unk003;

	[FieldOffset(34)]
	public TBool Unk004;

	[FieldOffset(35)]
	public TBool Unk005;

}
