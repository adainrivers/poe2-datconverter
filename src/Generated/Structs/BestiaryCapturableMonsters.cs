namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BestiaryCapturableMonsters
{
	[FieldOffset(0)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference MonsterVarietiesKey;

	[FieldOffset(16)]
	[ReferenceTable("BestiaryGroups")]
	public TableReference BestiaryGroupsKey;

	[FieldOffset(32)]
	[ReferenceTable("BestiaryEncounters")]
	public TableReference BestiaryEncountersKey;

	[FieldOffset(48)]
	public TBool Unk003;

	[FieldOffset(49)]
	public StringReference IconSmall;

	[FieldOffset(57)]
	public StringReference Icon;

	[FieldOffset(65)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference Boss_MonsterVarietiesKey;

	[FieldOffset(81)]
	[ReferenceTable("BestiaryGenus")]
	public TableReference BestiaryGenusKey;

	[FieldOffset(97)]
	public TBool Unk008;

	[FieldOffset(98)]
	[ReferenceTable("BestiaryCapturableMonsters")]
	public TableReference BestiaryCapturableMonstersKey;

	[FieldOffset(106)]
	public TBool IsDisabled;

	[FieldOffset(107)]
	public int Unk011;

	[FieldOffset(111)]
	public TBool Unk012;

}
