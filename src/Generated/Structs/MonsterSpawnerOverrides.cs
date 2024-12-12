namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MonsterSpawnerOverrides
{
	[FieldOffset(0)]
	public TableReference Unk000;

	[FieldOffset(16)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference Base_MonsterVarietiesKey;

	[FieldOffset(32)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference Override_MonsterVarietiesKey;

}
