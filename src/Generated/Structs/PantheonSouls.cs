namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct PantheonSouls
{
	[FieldOffset(0)]
	[ReferenceTable("WorldAreas")]
	public TableReference WorldArea;

	[FieldOffset(16)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference CapturedVessel;

	[FieldOffset(32)]
	[ReferenceTable("QuestFlags")]
	public TableReference QuestFlagUpgrade;

	[FieldOffset(48)]
	[ReferenceTable("MonsterVarieties")]
	[ElementType(typeof(TableReference))]
	public ArrayReference CapturedMonster;

	[FieldOffset(64)]
	[ReferenceTable("PantheonPanelLayout")]
	public TableReference PanelLayout;

	[FieldOffset(80)]
	public StringReference CapturedMonsterDescription;

	[FieldOffset(88)]
	public int Unk006;

	[FieldOffset(92)]
	[ReferenceTable("QuestFlags")]
	public TableReference QuestFlagDowngrade;

}
