namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AtlasUpgradesInventoryLayout
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public int Unk001;

	[FieldOffset(12)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference Voidstone;

	[FieldOffset(28)]
	public int Unk003;

	[FieldOffset(32)]
	public StringReference Objective;

	[FieldOffset(40)]
	[ReferenceTable("QuestFlags")]
	public TableReference GrantAtlasUpgrade;

	[FieldOffset(56)]
	public TableReference Unk006;

}
