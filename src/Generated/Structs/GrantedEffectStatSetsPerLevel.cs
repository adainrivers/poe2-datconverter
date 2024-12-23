namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct GrantedEffectStatSetsPerLevel
{
	[FieldOffset(0)]
	[ReferenceTable("GrantedEffectStatSets")]
	public TableReference StatSet;

	[FieldOffset(16)]
	public int GemLevel;

	//[FieldOffset(20)]
	//public float PlayerLevelReq;

	//[FieldOffset(24)]
	//public int SpellCritChance;

	//[FieldOffset(28)]
	//public int AttackCritChance;

	//[FieldOffset(32)]
	//public int BaseMultiplier;

	//[FieldOffset(36)]
	//public int DamageEffectiveness;

	[FieldOffset(28)]
	[ElementType(typeof(int))]
	public ArrayReference BaseResolvedValues;

	[FieldOffset(44)]
	[ElementType(typeof(int))]
	public ArrayReference AdditionalStatsValues;

	[FieldOffset(60)]
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

	[FieldOffset(129)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TableReference))]
	public ArrayReference AdditionalStats;

	[FieldOffset(145)]
	[ReferenceTable("StatInterpolationTypes")]
	[EnumName("StatInterpolationTypes")]
	[ElementType(typeof(TEnum))]
	public ArrayReference StatInterpolations;

	[FieldOffset(161)]
	[ElementType(typeof(float))]
	public ArrayReference FloatStatsValues;

    [FieldOffset(177)]
    public float PlayerLevel;

    [FieldOffset(181)]
    public int AdditionalBaseDamage;

}
