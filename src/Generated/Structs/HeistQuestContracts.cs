using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HeistQuestContracts
{
	[FieldOffset(0)]
	[ReferenceTable("HeistContracts")]
	public TRef HeistContractsKey;

	[FieldOffset(16)]
	[ReferenceTable("HeistObjectives")]
	public TRef HeistObjectivesKey;

	[FieldOffset(32)]
	[ReferenceTable("HeistNPCs")]
	[ElementType(typeof(TRef))]
	public TArray HeistNPCsKey;

	[FieldOffset(48)]
	[ReferenceTable("HeistJobs")]
	public TRef HeistJobsKey;

	[FieldOffset(64)]
	public int Unk004;

	[FieldOffset(68)]
	public int Unk005;

	[FieldOffset(72)]
	public int Unk006;

	[FieldOffset(76)]
	public bool Unk007;

	[FieldOffset(77)]
	[ReferenceTable("HeistRooms")]
	public TRef HeistRoomsKey1;

	[FieldOffset(93)]
	[ReferenceTable("WorldAreas")]
	public TRef WorldAreasKey;

	[FieldOffset(109)]
	public bool Unk010;

	[FieldOffset(110)]
	public bool Unk011;

	[FieldOffset(111)]
	public int Unk012;

	[FieldOffset(115)]
	public int Unk013;

	[FieldOffset(119)]
	public bool Unk014;

	[FieldOffset(120)]
	public bool Unk015;

	[FieldOffset(121)]
	[ReferenceTable("QuestFlags")]
	public TRef HaveObjective;

	[FieldOffset(137)]
	public bool Unk017;

	[FieldOffset(138)]
	[ReferenceTable("QuestFlags")]
	public TRef QuestActive;

	[FieldOffset(154)]
	[ReferenceTable("QuestFlags")]
	public TRef HaveQuest;

	[FieldOffset(170)]
	[ReferenceTable("QuestFlags")]
	public TRef HaveObjective2;

	[FieldOffset(186)]
	public bool Unk021;

	[FieldOffset(187)]
	public bool Unk022;

	[FieldOffset(188)]
	public TString Objective;

	[FieldOffset(196)]
	public bool Unk024;

	[FieldOffset(197)]
	[ReferenceTable("BaseItemTypes")]
	public TRef BaseItemTypesKey;

	[FieldOffset(213)]
	public bool Unk026;

	[FieldOffset(214)]
	[ReferenceTable("HeistIntroAreas")]
	public TRef HeistIntroAreasKey;

	[FieldOffset(230)]
	public int Unk028;

	[FieldOffset(234)]
	[ReferenceTable("HeistRooms")]
	public TRef HeistRoomsKey2;

	[FieldOffset(250)]
	public TString Unk030;

}
