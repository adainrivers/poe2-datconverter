namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AtlasPrimordialBosses
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public int Unk001;

	[FieldOffset(12)]
	public int Unk002;

	[FieldOffset(16)]
	public int Unk003;

	[FieldOffset(20)]
	public int Unk004;

	[FieldOffset(24)]
	[ReferenceTable("MiscAnimated")]
	public TableReference InfluenceComplete;

	[FieldOffset(40)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference MiniBossInvitation;

	[FieldOffset(56)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference BossInvitation;

	[FieldOffset(72)]
	[ReferenceTable("QuestFlags")]
	public TableReference PickUpKey;

	[FieldOffset(88)]
	public TableReference Unk009;

	[FieldOffset(104)]
	public TableReference Unk010;

	[FieldOffset(120)]
	[ReferenceTable("Tags")]
	public TableReference Tag;

	[FieldOffset(136)]
	[ReferenceTable("MiscObjects")]
	public TableReference Altar;

	[FieldOffset(152)]
	[ReferenceTable("MiscAnimated")]
	public TableReference AltarActivated;

}
