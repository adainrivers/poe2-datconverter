namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct IncursionUniqueUpgradeComponents
{
	[FieldOffset(0)]
	[ReferenceTable("Words")]
	public TableReference BaseUnique;

	[FieldOffset(16)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference UpgradeCurrency;

}
