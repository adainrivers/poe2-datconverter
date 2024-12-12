namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct PassiveSkillOverrides
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference Name;

	[FieldOffset(16)]
	public StringReference NodeIcon;

	[FieldOffset(24)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Stats;

	[FieldOffset(40)]
	[ElementType(typeof(int))]
	public ArrayReference StatValues;

	[FieldOffset(56)]
	public int HASH16;

	[FieldOffset(60)]
	public StringReference PassiveBG;

	[FieldOffset(68)]
	[ReferenceTable("GrantedEffectsPerLevel")]
	public TableReference Effect;

	[FieldOffset(84)]
	[ReferenceTable("PassiveSkillOverrideTypes")]
	public TableReference Type;

	[FieldOffset(100)]
	[ReferenceTable("PassiveOverrideLimits")]
	public TableReference Limit;

	[FieldOffset(116)]
	public int RequiresAdjacent;

	[FieldOffset(120)]
	public int MaxAdjacent;

	[FieldOffset(124)]
	[ReferenceTable("PassiveSkills")]
	public TableReference AllocatedPassiveSkill;

}
