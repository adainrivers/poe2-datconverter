namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AncestralTrialPositionType
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference PlayerTotemIcon;

	[FieldOffset(16)]
	public StringReference Name;

	[FieldOffset(24)]
	public StringReference EnemyTotemIcon;

	[FieldOffset(32)]
	public StringReference PlayerTotemSmallIcon;

	[FieldOffset(40)]
	public StringReference EnemyTotemSmallIcon;

}
