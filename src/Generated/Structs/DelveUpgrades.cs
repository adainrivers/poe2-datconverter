namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct DelveUpgrades
{
	[FieldOffset(0)]
	public int DelveUpgradeTypeKey;

	[FieldOffset(4)]
	public int UpgradeLevel;

	[FieldOffset(8)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TableReference))]
	public ArrayReference StatsKeys;

	[FieldOffset(24)]
	[ElementType(typeof(int))]
	public ArrayReference StatValues;

	[FieldOffset(40)]
	public int Cost;

	[FieldOffset(44)]
	public int Unk005;

	[FieldOffset(48)]
	[ReferenceTable("AchievementItems")]
	public TableReference AchievementItemsKey;

	[FieldOffset(64)]
	public int Unk007;

}
