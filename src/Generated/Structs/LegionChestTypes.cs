namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct LegionChestTypes
{
	[FieldOffset(0)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference Unk000;

	[FieldOffset(16)]
	[ReferenceTable("Chests")]
	public TableReference Chest;

	[FieldOffset(32)]
	[ReferenceTable("Chests")]
	public TableReference HardmodeChest;

	[FieldOffset(48)]
	public int Unk003;

	[FieldOffset(52)]
	[ReferenceTable("LegionFactions")]
	public TableReference Faction;

}
