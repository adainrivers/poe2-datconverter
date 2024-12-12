namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ExpeditionNPCs
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("NPCs")]
	[ElementType(typeof(TableReference))]
	public ArrayReference NPCs;

	[FieldOffset(24)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference RerollItem;

	[FieldOffset(40)]
	public int Unk003;

	[FieldOffset(44)]
	public int Unk004;

	[FieldOffset(48)]
	[ReferenceTable("QuestFlags")]
	public TableReference Unk005;

	[FieldOffset(64)]
	[ReferenceTable("ExpeditionFactions")]
	public TableReference Faction;

	[FieldOffset(80)]
	[ReferenceTable("NPCTextAudio")]
	public TableReference Reroll;

	[FieldOffset(96)]
	[ReferenceTable("NPCTextAudio")]
	public TableReference AllBombsPlaced;

	[FieldOffset(112)]
	[ReferenceTable("NPCTextAudio")]
	public TableReference BombPlacedRemnant;

	[FieldOffset(128)]
	[ReferenceTable("NPCTextAudio")]
	public TableReference BombPlacedTreasure;

	[FieldOffset(144)]
	[ReferenceTable("NPCTextAudio")]
	public TableReference BombPlacedMonsters;

	[FieldOffset(160)]
	[ReferenceTable("NPCTextAudio")]
	public TableReference BombPlacedGeneric;

	[FieldOffset(176)]
	[ReferenceTable("NPCTextAudio")]
	public TableReference EncounterComplete;

	[FieldOffset(192)]
	public int Unk014;

	[FieldOffset(196)]
	public int Unk015;

}
