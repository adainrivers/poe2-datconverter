using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct TieredMicrotransactions
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TRef MTX;

	[FieldOffset(16)]
	[ElementType(typeof(int))]
	public TArray TierThresholds;

	[FieldOffset(32)]
	[ReferenceTable("Stats")]
	public TRef Unk002;

	[FieldOffset(48)]
	[ElementType(typeof(int))]
	public TArray Unk003;

	[FieldOffset(64)]
	[ReferenceTable("Stats")]
	public TRef Unk004;

	[FieldOffset(80)]
	public int TierCount;

	[FieldOffset(84)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TRef))]
	public TArray Unk006;

	[FieldOffset(100)]
	[ElementType(typeof(int))]
	public TArray Unk007;

	[FieldOffset(116)]
	[ElementType(typeof(int))]
	public TArray Unk008;

	[FieldOffset(132)]
	public bool Unk009;

	[FieldOffset(133)]
	public bool Unk010;

	[FieldOffset(134)]
	[ReferenceTable("Stats")]
	public TRef Unk011;

	[FieldOffset(150)]
	public bool Unk012;

}
