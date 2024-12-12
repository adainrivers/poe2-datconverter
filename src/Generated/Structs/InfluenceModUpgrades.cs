namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct InfluenceModUpgrades
{
	[FieldOffset(0)]
	[ReferenceTable("Mods")]
	public TableReference InfluenceMod;

	[FieldOffset(16)]
	[ReferenceTable("Mods")]
	public TableReference UpgradedMod;

	[FieldOffset(32)]
	public TBool HighestTier;

}
