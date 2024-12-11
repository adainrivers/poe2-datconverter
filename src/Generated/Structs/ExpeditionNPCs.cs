using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ExpeditionNPCs
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("NPCs")]
	[ElementType(typeof(TRef))]
	public TArray NPCs;

	[FieldOffset(24)]
	[ReferenceTable("BaseItemTypes")]
	public TRef RerollItem;

	[FieldOffset(40)]
	public int Unk003;

	[FieldOffset(44)]
	public int Unk004;

	[FieldOffset(48)]
	[ReferenceTable("QuestFlags")]
	public TRef Unk005;

	[FieldOffset(64)]
	[ReferenceTable("ExpeditionFactions")]
	public TRef Faction;

	[FieldOffset(80)]
	[ReferenceTable("NPCTextAudio")]
	public TRef Reroll;

	[FieldOffset(96)]
	[ReferenceTable("NPCTextAudio")]
	public TRef AllBombsPlaced;

	[FieldOffset(112)]
	[ReferenceTable("NPCTextAudio")]
	public TRef BombPlacedRemnant;

	[FieldOffset(128)]
	[ReferenceTable("NPCTextAudio")]
	public TRef BombPlacedTreasure;

	[FieldOffset(144)]
	[ReferenceTable("NPCTextAudio")]
	public TRef BombPlacedMonsters;

	[FieldOffset(160)]
	[ReferenceTable("NPCTextAudio")]
	public TRef BombPlacedGeneric;

	[FieldOffset(176)]
	[ReferenceTable("NPCTextAudio")]
	public TRef EncounterComplete;

	[FieldOffset(192)]
	public int Unk014;

	[FieldOffset(196)]
	public int Unk015;

}
