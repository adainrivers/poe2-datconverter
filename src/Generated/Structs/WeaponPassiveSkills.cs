namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct WeaponPassiveSkills
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public int Tier;

	[FieldOffset(12)]
	[ReferenceTable("Mods")]
	public TableReference Mod;

	[FieldOffset(28)]
	[ElementType(typeof(int))]
	public ArrayReference Unk003;

	[FieldOffset(44)]
	[ElementType(typeof(int))]
	public ArrayReference Unk004;

	[FieldOffset(60)]
	public StringReference Icon;

	[FieldOffset(68)]
	[ReferenceTable("WeaponPassiveSkillTypes")]
	public TableReference Type;

	[FieldOffset(84)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Achievements;

}
