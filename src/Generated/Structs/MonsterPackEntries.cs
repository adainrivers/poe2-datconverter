namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MonsterPackEntries
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("MonsterPacks")]
	public TableReference MonsterPacksKey;

	[FieldOffset(24)]
	public TBool Unk002;

	[FieldOffset(25)]
	public int Unk003;

	[FieldOffset(29)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference MonsterVarietiesKey;

	[FieldOffset(45)]
	[ReferenceTable("MonsterPackEntries")]
	public TableReference Unk005;

}
