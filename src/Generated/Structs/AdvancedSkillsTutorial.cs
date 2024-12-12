namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AdvancedSkillsTutorial
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("SkillGemInfo")]
	[ElementType(typeof(TableReference))]
	public ArrayReference SkillGemInfoKey1;

	[FieldOffset(24)]
	[ReferenceTable("SkillGemInfo")]
	[ElementType(typeof(TableReference))]
	public ArrayReference SkillGemInfoKey2;

	[FieldOffset(40)]
	public StringReference Description;

	[FieldOffset(48)]
	public StringReference International_BK2File;

	[FieldOffset(56)]
	[ReferenceTable("SkillGems")]
	public TableReference SkillGemsKey;

	[FieldOffset(72)]
	public StringReference China_BK2File;

	[FieldOffset(80)]
	[ReferenceTable("Characters")]
	[ElementType(typeof(TableReference))]
	public ArrayReference CharactersKey;

}
