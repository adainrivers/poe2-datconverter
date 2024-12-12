namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct NecropolisPackMods
{
	[FieldOffset(0)]
	[ReferenceTable("Mods")]
	public TableReference Mod;

	[FieldOffset(16)]
	[ReferenceTable("NecropolisPackModTiers")]
	public TableReference Tier;

	[FieldOffset(32)]
	[ReferenceTable("NecropolisPackMods")]
	public TableReference NextTier;

	[FieldOffset(40)]
	[ReferenceTable("NecropolisPackMods")]
	public TableReference PrevTier;

}
