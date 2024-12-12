namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HellscapeMonsterPacks
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("MonsterPacks")]
	public TableReference MonsterPack;

	[FieldOffset(24)]
	[ReferenceTable("HellscapeFactions")]
	public TableReference Faction;

	[FieldOffset(40)]
	public TBool IsDonutPack;

	[FieldOffset(41)]
	public TBool IsElite;

	[FieldOffset(42)]
	public int MinLevel;

	[FieldOffset(46)]
	public int MaxLevel;

}
