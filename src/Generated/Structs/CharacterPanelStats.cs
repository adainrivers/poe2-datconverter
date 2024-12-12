namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct CharacterPanelStats
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference Text;

	[FieldOffset(16)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TableReference))]
	public ArrayReference StatsKeys1;

	[FieldOffset(32)]
	[ReferenceTable("CharacterPanelDescriptionModes")]
	public TableReference CharacterPanelDescriptionModesKey;

	[FieldOffset(48)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TableReference))]
	public ArrayReference StatsKeys2;

	[FieldOffset(64)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TableReference))]
	public ArrayReference StatsKeys3;

	[FieldOffset(80)]
	[ReferenceTable("CharacterPanelTabs")]
	public TableReference CharacterPanelTabsKey;

	[FieldOffset(96)]
	public TBool Unk007;

	[FieldOffset(97)]
	[ElementType(typeof(int))]
	public ArrayReference Unk008;

	[FieldOffset(113)]
	public int Unk009;

}
