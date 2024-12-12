namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BestiaryGenus
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference Name;

	[FieldOffset(16)]
	[ReferenceTable("BestiaryGroups")]
	public TableReference BestiaryGroupsKey;

	[FieldOffset(32)]
	public StringReference Name2;

	[FieldOffset(40)]
	public StringReference Icon;

}
