namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AchievementSetRewards
{
	[FieldOffset(0)]
	[ReferenceTable("AchievementSetsDisplay")]
	public int SetId;

	[FieldOffset(4)]
	public int AchievementsRequired;

	[FieldOffset(8)]
	[ReferenceTable("BaseItemTypes")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Rewards;

	[FieldOffset(24)]
	public int TotemPieceEveryNAchievements;

	[FieldOffset(28)]
	public StringReference Message;

	[FieldOffset(36)]
	public StringReference NotificationIcon;

	[FieldOffset(44)]
	public StringReference HideoutName;

	[FieldOffset(52)]
	public StringReference Id;

}
