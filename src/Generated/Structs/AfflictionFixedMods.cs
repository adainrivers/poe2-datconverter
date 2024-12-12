namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AfflictionFixedMods
{
	[FieldOffset(0)]
	public int Rarity;

	[FieldOffset(4)]
	[ReferenceTable("Mods")]
	public TableReference Mod;

	[FieldOffset(20)]
	public TableReference Unk002;

}
