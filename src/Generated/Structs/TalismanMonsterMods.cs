namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct TalismanMonsterMods
{
	[FieldOffset(0)]
	[ReferenceTable("ModType")]
	public TableReference ModTypeKey;

	[FieldOffset(16)]
	[ReferenceTable("Mods")]
	public TableReference ModsKey;

}
