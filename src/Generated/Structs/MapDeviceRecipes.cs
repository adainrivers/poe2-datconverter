namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MapDeviceRecipes
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("BaseItemTypes")]
	[ElementType(typeof(TableReference))]
	public ArrayReference RecipeItems;

	[FieldOffset(24)]
	[ReferenceTable("WorldAreas")]
	public TableReference WorldArea;

	[FieldOffset(40)]
	[ReferenceTable("MicrotransactionPortalVariations")]
	public TableReference MicrotransactionPortalVariation;

	[FieldOffset(56)]
	public int AreaLevel;

	[FieldOffset(60)]
	public TableReference Unk005;

	[FieldOffset(76)]
	public int Unk006;

	[FieldOffset(80)]
	public TBool Unk007;

	[FieldOffset(81)]
	public TBool Unk008;

	[FieldOffset(82)]
	public TBool Unk009;

	[FieldOffset(83)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference OpenAchievemnts;

	[FieldOffset(99)]
	public TBool Unk011;

	[FieldOffset(100)]
	public int Unk012;

	[FieldOffset(104)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk013;

	[FieldOffset(120)]
	public TBool Unk014;

}
