namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct TormentSpirits
{
	[FieldOffset(0)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference MonsterVarietiesKey;

	[FieldOffset(16)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Spirit_ModsKeys;

	[FieldOffset(32)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Touched_ModsKeys;

	[FieldOffset(48)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Possessed_ModsKeys;

	[FieldOffset(64)]
	public int MinZoneLevel;

	[FieldOffset(68)]
	public int MaxZoneLevel;

	[FieldOffset(72)]
	public int SpawnWeight;

	[FieldOffset(76)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference SummonedMonster_MonsterVarietiesKey;

	[FieldOffset(92)]
	public int Unk008;

	[FieldOffset(96)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TableReference))]
	public ArrayReference ModsKeys0;

	[FieldOffset(112)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TableReference))]
	public ArrayReference ModsKeys1;

}
