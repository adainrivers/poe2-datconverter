using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SentinelTaggedMonsterStats
{
	[FieldOffset(0)]
	[ReferenceTable("Stats")]
	public TRef TaggedStat;

	[FieldOffset(16)]
	[ReferenceTable("Stats")]
	public TRef Unk001;

	[FieldOffset(32)]
	[ElementType(typeof(TRef))]
	public TArray Unk002;

	[FieldOffset(48)]
	public TRef Unk003;

	[FieldOffset(64)]
	public TRef Unk004;

}
