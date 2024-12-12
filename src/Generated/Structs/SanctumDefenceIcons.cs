namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SanctumDefenceIcons
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("Stats")]
	public TableReference Stat;

	[FieldOffset(24)]
	public StringReference DefenceIcon;

	[FieldOffset(32)]
	public StringReference DefenceBrokenIcon;

	[FieldOffset(40)]
	[ReferenceTable("Stats")]
	public TableReference BrokenStat;

	[FieldOffset(56)]
	public StringReference Description;

}
