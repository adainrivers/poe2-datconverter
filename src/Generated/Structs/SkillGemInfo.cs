namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SkillGemInfo
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference Description;

	[FieldOffset(16)]
	public StringReference VideoURL1;

	[FieldOffset(24)]
	[ReferenceTable("SkillGems")]
	public TableReference SkillGemsKey;

	[FieldOffset(40)]
	public StringReference VideoURL2;

	[FieldOffset(48)]
	[ReferenceTable("Characters")]
	[ElementType(typeof(TableReference))]
	public ArrayReference CharactersKeys;

}
