namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MapSeriesTiers
{
	[FieldOffset(0)]
	[ReferenceTable("Maps")]
	public TableReference MapsKey;

	[FieldOffset(16)]
	public int MapWorldsTier;

	[FieldOffset(20)]
	public int BetrayalTier;

	[FieldOffset(24)]
	public int SynthesisTier;

	[FieldOffset(28)]
	public int LegionTier;

	[FieldOffset(32)]
	public int BlightTier;

	[FieldOffset(36)]
	public int MetamorphosisTier;

	[FieldOffset(40)]
	public int DeliriumTier;

	[FieldOffset(44)]
	public int HarvestTier;

	[FieldOffset(48)]
	public int HeistTier;

	[FieldOffset(52)]
	public int RitualTier;

	[FieldOffset(56)]
	public int ExpeditionTier;

	[FieldOffset(60)]
	public int ScourgeTier;

	[FieldOffset(64)]
	public int ArchnemesisTier;

	[FieldOffset(68)]
	public int SentinelTier;

	[FieldOffset(72)]
	public int KalandraTier;

	[FieldOffset(76)]
	public int SanctumTier;

	[FieldOffset(80)]
	public int CrucibleTier;

	[FieldOffset(84)]
	public int AncestorTier;

	[FieldOffset(88)]
	public int AzmeriTier;

	[FieldOffset(92)]
	public int NecropolisTier;

	[FieldOffset(96)]
	public int SettlersTier;

}
