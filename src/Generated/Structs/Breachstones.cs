namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Breachstones
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference BaseType;

	[FieldOffset(16)]
	public int MapTierEquivalent;

	[FieldOffset(20)]
	public int Unk002;

	[FieldOffset(24)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference UpgradesTo;

	[FieldOffset(40)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference UpgradeCurrency;

}
