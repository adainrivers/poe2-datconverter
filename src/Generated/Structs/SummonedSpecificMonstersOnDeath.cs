namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SummonedSpecificMonstersOnDeath
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference MonsterVarietiesKey;

	[FieldOffset(24)]
	public int Unk002;

	[FieldOffset(28)]
	public TableReference Unk003;

	[FieldOffset(44)]
	public int Unk004;

	[FieldOffset(48)]
	public TBool Unk005;

}
