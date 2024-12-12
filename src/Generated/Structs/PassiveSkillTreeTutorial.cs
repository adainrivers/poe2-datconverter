namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct PassiveSkillTreeTutorial
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("Characters")]
	public TableReference CharactersKey;

	[FieldOffset(24)]
	public TableReference Unk002;

	[FieldOffset(40)]
	public StringReference ChoiceA_Description;

	[FieldOffset(48)]
	public StringReference ChoiceB_Description;

	[FieldOffset(56)]
	public TableReference Unk005;

	[FieldOffset(72)]
	public StringReference ChoiceA_PassiveTreeURL;

	[FieldOffset(80)]
	public StringReference ChoiceB_PassiveTreeURL;

	[FieldOffset(88)]
	public TableReference Unk008;

	[FieldOffset(104)]
	public TableReference Unk009;

}
