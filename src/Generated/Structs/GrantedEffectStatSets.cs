using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct GrantedEffectStatSets
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TRef))]
	public TArray ImplicitStats;

	[FieldOffset(24)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TRef))]
	public TArray ConstantStats;

	[FieldOffset(40)]
	[ElementType(typeof(int))]
	public TArray ConstantStatsValues;

	[FieldOffset(56)]
	public float BaseEffectiveness;

	[FieldOffset(60)]
	public float IncrementalEffectiveness;

	[FieldOffset(64)]
	public int Unk006;

}
