namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct GrantedEffectStatSets
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TableReference))]
	public ArrayReference ImplicitStats;

	[FieldOffset(24)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TableReference))]
	public ArrayReference ConstantStats;

	[FieldOffset(40)]
	[ElementType(typeof(int))]
	public ArrayReference ConstantStatsValues;

	[FieldOffset(56)]
	public float BaseEffectiveness;

	[FieldOffset(60)]
	public float IncrementalEffectiveness;

	[FieldOffset(64)]
	public int Unk006;

}
