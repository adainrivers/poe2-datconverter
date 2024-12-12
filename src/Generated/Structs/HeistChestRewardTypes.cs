namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HeistChestRewardTypes
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference Art;

	[FieldOffset(16)]
	public StringReference RewardTypeName;

	[FieldOffset(24)]
	[ReferenceTable("HeistChestRewardTypes")]
	public TableReference Unk003;

	[FieldOffset(32)]
	public StringReference RewardRoomName;

	[FieldOffset(40)]
	public int MinLevel;

	[FieldOffset(44)]
	public int MaxLevel;

	[FieldOffset(48)]
	public int Weight;

	[FieldOffset(52)]
	public StringReference RewardRoomName2;

	[FieldOffset(60)]
	[ReferenceTable("HeistJobs")]
	[ElementType(typeof(TableReference))]
	public ArrayReference HeistJobsKey;

	[FieldOffset(76)]
	public int Unk010;

	[FieldOffset(80)]
	public int Unk011;

}
