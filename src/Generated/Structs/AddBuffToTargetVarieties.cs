using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AddBuffToTargetVarieties
{
	[FieldOffset(0)]
	[ReferenceTable("BuffDefinitions")]
	public TRef BuffDefinitions;

	[FieldOffset(16)]
	[ElementType(typeof(int))]
	public TArray Unk001;

	[FieldOffset(32)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TRef))]
	public TArray StatsKeys;

	[FieldOffset(48)]
	public int Unk003;

	[FieldOffset(52)]
	[ElementType(typeof(int))]
	public TArray Unk004;

	[FieldOffset(68)]
	public int Unk005;

	[FieldOffset(72)]
	public int Unk006;

	[FieldOffset(76)]
	[ElementType(typeof(int))]
	public TArray Unk007;

}
