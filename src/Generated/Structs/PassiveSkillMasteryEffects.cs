namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct PassiveSkillMasteryEffects
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public short HASH16;

	[FieldOffset(10)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Stats;

	[FieldOffset(26)]
	public int Stat1Value;

	[FieldOffset(30)]
	public int Stat2Value;

	[FieldOffset(34)]
	public int Stat3Value;

	[FieldOffset(38)]
	[ReferenceTable("AchievementItems")]
	public TableReference AchievementItem;

	[FieldOffset(54)]
	public TableReference Unk007;

}
