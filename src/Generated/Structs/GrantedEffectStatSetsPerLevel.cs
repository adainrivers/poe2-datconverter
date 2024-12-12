namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct GrantedEffectStatSetsPerLevel
{
	[FieldOffset(0)]
	[ReferenceTable("GrantedEffectStatSets")]
	public TableReference StatSet;

	[FieldOffset(16)]
	public int GemLevel;

	[FieldOffset(20)]
	public float PlayerLevelReq;

	[FieldOffset(24)]
	public int SpellCritChance;

	[FieldOffset(28)]
	public int AttackCritChance;

	[FieldOffset(32)]
	public int BaseMultiplier;

	[FieldOffset(36)]
	public int DamageEffectiveness;

	[FieldOffset(40)]
	[ElementType(typeof(int))]
	public ArrayReference BaseResolvedValues;

	[FieldOffset(56)]
	[ElementType(typeof(int))]
	public ArrayReference AdditionalStatsValues;

	[FieldOffset(72)]
	[ReferenceTable("GrantedEffects")]
	[ElementType(typeof(TableReference))]
	public ArrayReference GrantedEffects;

	[FieldOffset(88)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TableReference))]
	public ArrayReference AdditionalFlags;

	[FieldOffset(104)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TableReference))]
	public ArrayReference FloatStats;

	[FieldOffset(120)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TableReference))]
	public ArrayReference InterpolationBases;

	[FieldOffset(136)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TableReference))]
	public ArrayReference AdditionalStats;

	[FieldOffset(152)]
	[ReferenceTable("StatInterpolationTypes")]
	[EnumName("StatInterpolationTypes")]
	[ElementType(typeof(TEnum))]
	public ArrayReference StatInterpolations;

	[FieldOffset(168)]
	[ElementType(typeof(float))]
	public ArrayReference FloatStatsValues;

}
