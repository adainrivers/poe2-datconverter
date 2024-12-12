namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct CharacterStartStates
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference Description;

	[FieldOffset(16)]
	[ReferenceTable("Characters")]
	public TableReference CharactersKey;

	[FieldOffset(32)]
	public int Level;

	[FieldOffset(36)]
	[ReferenceTable("PassiveSkills")]
	[ElementType(typeof(TableReference))]
	public ArrayReference PassiveSkillsKeys;

	[FieldOffset(52)]
	[ReferenceTable("CharacterStartStateSet")]
	public TableReference CharacterStartStateSetKey;

	[FieldOffset(68)]
	public TableReference Unk006;

	[FieldOffset(84)]
	[ReferenceTable("CharacterStartQuestState")]
	[ElementType(typeof(TableReference))]
	public ArrayReference CharacterStartQuestStateKeys;

	[FieldOffset(100)]
	public TBool Unk008;

	[FieldOffset(101)]
	public StringReference InfoText;

	[FieldOffset(109)]
	public TableReference Unk010;

}
