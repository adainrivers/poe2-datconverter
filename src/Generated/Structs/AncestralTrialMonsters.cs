namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AncestralTrialMonsters
{
	[FieldOffset(0)]
	public TableReference Unk000;

	[FieldOffset(16)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference Monster;

	[FieldOffset(32)]
	public TableReference Unk002;

	[FieldOffset(48)]
	public int Unk003;

	[FieldOffset(52)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Achievement;

	[FieldOffset(68)]
	public TBool Unk005;

	[FieldOffset(69)]
	public TBool Unk006;

	[FieldOffset(70)]
	public TBool Unk007;

	[FieldOffset(71)]
	public TBool Unk008;

}
