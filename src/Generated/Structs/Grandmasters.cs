namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Grandmasters
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference GMFile;

	[FieldOffset(16)]
	public StringReference AISFile;

	[FieldOffset(24)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TableReference))]
	public ArrayReference ModsKeys;

	[FieldOffset(40)]
	public int CharacterLevel;

	[FieldOffset(44)]
	public TBool Unk005;

}
