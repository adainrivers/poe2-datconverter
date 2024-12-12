namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct CorpseTypeTags
{
	[FieldOffset(0)]
	[ReferenceTable("Tags")]
	public TableReference Tag;

	[FieldOffset(16)]
	public StringReference Name;

	[FieldOffset(24)]
	[ReferenceTable("BuffDefinitions")]
	public TableReference RavenousBuff;

	[FieldOffset(40)]
	public StringReference Icon;

	[FieldOffset(48)]
	public int Unk004;

}
