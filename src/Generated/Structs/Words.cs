namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Words
{
	[FieldOffset(0)]
	[ReferenceTable("Wordlists")]
	[EnumName("Wordlists")]
	public TEnum Wordlist;

	[FieldOffset(4)]
	public StringReference Text;

	[FieldOffset(12)]
	[ReferenceTable("Tags")]
	[ElementType(typeof(TableReference))]
	public ArrayReference SpawnWeight_Tags;

	[FieldOffset(28)]
	[ElementType(typeof(int))]
	public ArrayReference SpawnWeight_Values;

	[FieldOffset(44)]
	public int Unk004;

	[FieldOffset(48)]
	public StringReference Text2;

	[FieldOffset(56)]
	public StringReference Inflection;

}
