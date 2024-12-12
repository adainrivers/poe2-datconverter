namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HeistQuestContracts
{
	[FieldOffset(0)]
	[ReferenceTable("HeistContracts")]
	public TableReference HeistContractsKey;

	[FieldOffset(16)]
	[ReferenceTable("HeistObjectives")]
	public TableReference HeistObjectivesKey;

	[FieldOffset(32)]
	[ReferenceTable("HeistNPCs")]
	[ElementType(typeof(TableReference))]
	public ArrayReference HeistNPCsKey;

	[FieldOffset(48)]
	[ReferenceTable("HeistJobs")]
	public TableReference HeistJobsKey;

	[FieldOffset(64)]
	public int Unk004;

	[FieldOffset(68)]
	public int Unk005;

	[FieldOffset(72)]
	public int Unk006;

	[FieldOffset(76)]
	public TBool Unk007;

	[FieldOffset(77)]
	[ReferenceTable("HeistRooms")]
	public TableReference HeistRoomsKey1;

	[FieldOffset(93)]
	[ReferenceTable("WorldAreas")]
	public TableReference WorldAreasKey;

	[FieldOffset(109)]
	public TBool Unk010;

	[FieldOffset(110)]
	public TBool Unk011;

	[FieldOffset(111)]
	public int Unk012;

	[FieldOffset(115)]
	public int Unk013;

	[FieldOffset(119)]
	public TBool Unk014;

	[FieldOffset(120)]
	public TBool Unk015;

	[FieldOffset(121)]
	[ReferenceTable("QuestFlags")]
	public TableReference HaveObjective;

	[FieldOffset(137)]
	public TBool Unk017;

	[FieldOffset(138)]
	[ReferenceTable("QuestFlags")]
	public TableReference QuestActive;

	[FieldOffset(154)]
	[ReferenceTable("QuestFlags")]
	public TableReference HaveQuest;

	[FieldOffset(170)]
	[ReferenceTable("QuestFlags")]
	public TableReference HaveObjective2;

	[FieldOffset(186)]
	public TBool Unk021;

	[FieldOffset(187)]
	public TBool Unk022;

	[FieldOffset(188)]
	public StringReference Objective;

	[FieldOffset(196)]
	public TBool Unk024;

	[FieldOffset(197)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference BaseItemTypesKey;

	[FieldOffset(213)]
	public TBool Unk026;

	[FieldOffset(214)]
	[ReferenceTable("HeistIntroAreas")]
	public TableReference HeistIntroAreasKey;

	[FieldOffset(230)]
	public int Unk028;

	[FieldOffset(234)]
	[ReferenceTable("HeistRooms")]
	public TableReference HeistRoomsKey2;

	[FieldOffset(250)]
	public StringReference Unk030;

}
