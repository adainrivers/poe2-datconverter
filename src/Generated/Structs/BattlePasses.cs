namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BattlePasses
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("LeagueCategory")]
	[EnumName("LeagueCategory")]
	public TEnum LeagueCategory;

	[FieldOffset(12)]
	public StringReference International_BK2File;

	[FieldOffset(20)]
	public StringReference China_BK2File;

	[FieldOffset(28)]
	public int MapCompletionCount;

	[FieldOffset(32)]
	public TBool Unk005;

	[FieldOffset(33)]
	public StringReference Id2;

}
