namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HeistAreas
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("WorldAreas")]
	[ElementType(typeof(TableReference))]
	public ArrayReference WorldAreasKeys;

	[FieldOffset(24)]
	public int Unk002;

	[FieldOffset(28)]
	[ReferenceTable("Environments")]
	public TableReference EnvironmentsKey1;

	[FieldOffset(44)]
	[ReferenceTable("Environments")]
	public TableReference EnvironmentsKey2;

	[FieldOffset(60)]
	[ReferenceTable("HeistJobs")]
	[ElementType(typeof(TableReference))]
	public ArrayReference HeistJobsKeys;

	[FieldOffset(76)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference Contract_BaseItemTypesKey;

	[FieldOffset(92)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference Blueprint_BaseItemTypesKey;

	[FieldOffset(108)]
	public StringReference DGRFile;

	[FieldOffset(116)]
	public int Unk009;

	[FieldOffset(120)]
	public int Unk010;

	[FieldOffset(124)]
	public TBool Unk011;

	[FieldOffset(125)]
	public TBool Unk012;

	[FieldOffset(126)]
	public StringReference Blueprint_DDSFile;

	[FieldOffset(134)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Achievements1;

	[FieldOffset(150)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Achievements2;

	[FieldOffset(166)]
	[ReferenceTable("ClientStrings")]
	public TableReference Reward;

	[FieldOffset(182)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Achievements3;

	[FieldOffset(198)]
	[ReferenceTable("ClientStrings")]
	public TableReference RewardHardmode;

}
