namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ModEquivalencies
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("Mods")]
	public TableReference ModsKey0;

	[FieldOffset(24)]
	[ReferenceTable("Mods")]
	public TableReference ModsKey1;

	[FieldOffset(40)]
	[ReferenceTable("Mods")]
	public TableReference ModsKey2;

	[FieldOffset(56)]
	public TBool Unk004;

}
