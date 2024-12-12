namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct UniqueChests
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("Words")]
	public TableReference WordsKey;

	[FieldOffset(24)]
	[ReferenceTable("FlavourText")]
	public TableReference FlavourTextKey;

	[FieldOffset(40)]
	public int MinLevel;

	[FieldOffset(44)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TableReference))]
	public ArrayReference ModsKeys;

	[FieldOffset(60)]
	public int SpawnWeight;

	[FieldOffset(64)]
	[ElementType(typeof(int))]
	public ArrayReference Unk006;

	[FieldOffset(80)]
	public StringReference AOFile;

	[FieldOffset(88)]
	public TBool Unk008;

	[FieldOffset(89)]
	[ElementType(typeof(int))]
	public ArrayReference Unk009;

	[FieldOffset(105)]
	[ReferenceTable("Chests")]
	public TableReference AppearanceChestsKey;

	[FieldOffset(121)]
	[ReferenceTable("Chests")]
	public TableReference ChestsKey;

	[FieldOffset(137)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk012;

}
