namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MapFragmentMods
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference BaseItemTypesKey;

	[FieldOffset(16)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TableReference))]
	public ArrayReference ModsKeys;

	[FieldOffset(32)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference AchievementItemsKey;

	[FieldOffset(48)]
	public int MapFragmentFamilies;

	[FieldOffset(52)]
	public TBool Unk004;

	[FieldOffset(53)]
	public TBool Unk005;

	[FieldOffset(54)]
	public TBool Unk006;

	[FieldOffset(55)]
	public TBool Unk007;

	[FieldOffset(56)]
	public TBool Unk008;

	[FieldOffset(57)]
	public TBool Unk009;

	[FieldOffset(58)]
	public int MinAreaLevel;

	[FieldOffset(62)]
	public int Unk011;

	[FieldOffset(66)]
	public int MapFragmentLimit;

	[FieldOffset(70)]
	public TBool Unk013;

}
