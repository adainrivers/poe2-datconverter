namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct PassiveSkillOverrideTypes
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("Stats")]
	public TableReference CounterStat;

	[FieldOffset(24)]
	public TBool Unk002;

}
