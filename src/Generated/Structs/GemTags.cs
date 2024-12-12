namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct GemTags
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference Tag;

	[FieldOffset(16)]
	[ReferenceTable("Stats")]
	public TableReference Stat1;

	[FieldOffset(32)]
	[ReferenceTable("Stats")]
	public TableReference Stat2;

	[FieldOffset(48)]
	[ReferenceTable("Stats")]
	public TableReference Stat3;

	[FieldOffset(64)]
	[ReferenceTable("Stats")]
	public TableReference Stat4;

}
