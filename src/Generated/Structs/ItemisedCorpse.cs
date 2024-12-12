namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ItemisedCorpse
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference BaseItem;

	[FieldOffset(16)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference MonsterVariety;

	[FieldOffset(32)]
	public StringReference MonsterAbilities;

	[FieldOffset(40)]
	[ReferenceTable("CorpseTypeTags")]
	public TableReference MonsterCategory;

}
