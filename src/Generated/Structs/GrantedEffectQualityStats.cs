namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct GrantedEffectQualityStats
{
	[FieldOffset(0)]
	[ReferenceTable("GrantedEffects")]
	public TableReference GrantedEffectsKey;

	[FieldOffset(16)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TableReference))]
	public ArrayReference StatsKeys;

	[FieldOffset(32)]
	[ElementType(typeof(int))]
	public ArrayReference StatsValuesPermille;

	[FieldOffset(48)]
	[ElementType(typeof(int))]
	public ArrayReference Unk003;

	[FieldOffset(64)]
	[ElementType(typeof(int))]
	public ArrayReference Unk004;

}
