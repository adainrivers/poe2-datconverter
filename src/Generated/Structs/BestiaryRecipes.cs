namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BestiaryRecipes
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference Description;

	[FieldOffset(16)]
	[ReferenceTable("BestiaryRecipeComponent")]
	[ElementType(typeof(TableReference))]
	public ArrayReference BestiaryRecipeComponentKeys;

	[FieldOffset(32)]
	public StringReference Notes;

	[FieldOffset(40)]
	[ReferenceTable("BestiaryRecipeCategories")]
	public TableReference Category;

	[FieldOffset(56)]
	public TBool Unk005;

	[FieldOffset(57)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Achievements;

	[FieldOffset(73)]
	public TBool Unk007;

	[FieldOffset(74)]
	public int Unk008;

	[FieldOffset(78)]
	public int Unk009;

	[FieldOffset(82)]
	public int GameMode;

	[FieldOffset(86)]
	[ReferenceTable("Mods")]
	public TableReference FlaskMod;

}
