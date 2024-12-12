namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct DroneBaseTypes
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference BaseType;

	[FieldOffset(16)]
	[ReferenceTable("DroneTypes")]
	public TableReference Type;

	[FieldOffset(32)]
	public int Charges;

	[FieldOffset(36)]
	public int Duration;

	[FieldOffset(40)]
	public int EnemyLimit;

	[FieldOffset(44)]
	[ReferenceTable("BuffVisuals")]
	public TableReference Visual;

	[FieldOffset(60)]
	public int Empowerment;

	[FieldOffset(64)]
	[ReferenceTable("AchievementItems")]
	public TableReference UseAchievement;

	[FieldOffset(80)]
	public TBool CreatedViaPowerCore;

}
