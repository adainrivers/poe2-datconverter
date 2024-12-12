namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BestiaryGroups
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference Description;

	[FieldOffset(16)]
	public StringReference Illustration;

	[FieldOffset(24)]
	public StringReference Name;

	[FieldOffset(32)]
	public StringReference Icon;

	[FieldOffset(40)]
	public StringReference IconSmall;

	[FieldOffset(48)]
	[ReferenceTable("BestiaryFamilies")]
	public TableReference BestiaryFamiliesKey;

	[FieldOffset(64)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference AchievementItemsKeys;

}
