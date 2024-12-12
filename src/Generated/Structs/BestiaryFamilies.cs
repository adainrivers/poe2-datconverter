namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BestiaryFamilies
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference Name;

	[FieldOffset(16)]
	public StringReference Icon;

	[FieldOffset(24)]
	public StringReference IconSmall;

	[FieldOffset(32)]
	public StringReference Illustration;

	[FieldOffset(40)]
	public StringReference PageArt;

	[FieldOffset(48)]
	public StringReference FlavourText;

	[FieldOffset(56)]
	public TBool Unk007;

	[FieldOffset(57)]
	[ReferenceTable("Tags")]
	public TableReference TagsKey;

	[FieldOffset(73)]
	public int Unk009;

	[FieldOffset(77)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TableReference))]
	public ArrayReference ModsKeys;

	[FieldOffset(93)]
	[ReferenceTable("CurrencyItems")]
	public TableReference CurrencyItemsKey;

}
