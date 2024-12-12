namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HarvestSeeds
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference Monster;

	[FieldOffset(24)]
	public int Tier;

	[FieldOffset(28)]
	public int Unk003;

	[FieldOffset(32)]
	[ElementType(typeof(int))]
	public ArrayReference Unk004;

	[FieldOffset(48)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Achievements;

	[FieldOffset(64)]
	public StringReference SeedAnimation;

	[FieldOffset(72)]
	public int Unk007;

	[FieldOffset(76)]
	public StringReference HatchAnimation;

	[FieldOffset(84)]
	public int SeedType;

}
