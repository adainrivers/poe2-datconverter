namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Archetypes
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("Characters")]
	public TableReference CharactersKey;

	[FieldOffset(24)]
	public StringReference PassiveSkillTreeURL;

	[FieldOffset(32)]
	public StringReference AscendancyClassName;

	[FieldOffset(40)]
	public StringReference Description;

	[FieldOffset(48)]
	public StringReference UIImageFile;

	[FieldOffset(56)]
	public StringReference TutorialVideo_BKFile;

	[FieldOffset(64)]
	public int Unk007;

	[FieldOffset(68)]
	public float Unk008;

	[FieldOffset(72)]
	public float Unk009;

	[FieldOffset(76)]
	public StringReference BackgroundImageFile;

	[FieldOffset(84)]
	public TBool IsTemporary;

	[FieldOffset(85)]
	public TBool Unk012;

	[FieldOffset(86)]
	public StringReference ArchetypeImage;

	[FieldOffset(94)]
	public TBool Unk014;

	[FieldOffset(95)]
	public TBool Unk015;

}
