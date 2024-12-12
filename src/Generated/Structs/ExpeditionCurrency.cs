namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ExpeditionCurrency
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference BaseItemType;

	[FieldOffset(16)]
	public int Tier;

	[FieldOffset(20)]
	[ReferenceTable("ExpeditionNPCs")]
	public TableReference NPC;

	[FieldOffset(36)]
	[ReferenceTable("SoundEffects")]
	public TableReference LootSound;

}
