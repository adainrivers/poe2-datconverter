using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ModEffectStats
{
	[FieldOffset(0)]
	[ReferenceTable("Stats")]
	public TRef StatsKey;

	[FieldOffset(16)]
	[ReferenceTable("Tags")]
	[ElementType(typeof(TRef))]
	public TArray TagsKeys;

	[FieldOffset(32)]
	public bool Unk002;

	[FieldOffset(33)]
	public int Unk003;

	[FieldOffset(37)]
	public bool Unk004;

	[FieldOffset(38)]
	public bool Unk005;

	[FieldOffset(39)]
	public bool Unk006;

}
