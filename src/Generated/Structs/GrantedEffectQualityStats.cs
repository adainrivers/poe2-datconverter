using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct GrantedEffectQualityStats
{
	[FieldOffset(0)]
	[ReferenceTable("GrantedEffects")]
	public TRef GrantedEffectsKey;

	[FieldOffset(16)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TRef))]
	public TArray StatsKeys;

	[FieldOffset(32)]
	[ElementType(typeof(int))]
	public TArray StatsValuesPermille;

	[FieldOffset(48)]
	[ElementType(typeof(int))]
	public TArray Unk003;

	[FieldOffset(64)]
	[ElementType(typeof(int))]
	public TArray Unk004;

}
