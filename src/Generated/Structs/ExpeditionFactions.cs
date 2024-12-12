namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ExpeditionFactions
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference Name;

	[FieldOffset(16)]
	public StringReference FactionFlag;

	[FieldOffset(24)]
	public int Unk003;

	[FieldOffset(28)]
	public StringReference FactionIcon;

	[FieldOffset(36)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference MonsterVarieties;

	[FieldOffset(52)]
	[ReferenceTable("NPCTextAudio")]
	public TableReference Progress1;

	[FieldOffset(68)]
	[ReferenceTable("NPCTextAudio")]
	public TableReference Progress2Vaal;

	[FieldOffset(84)]
	[ReferenceTable("NPCTextAudio")]
	public TableReference Progress3Final;

	[FieldOffset(100)]
	[ReferenceTable("Tags")]
	public TableReference Tags;

}
