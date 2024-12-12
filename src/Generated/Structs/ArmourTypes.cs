namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ArmourTypes
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference BaseItemTypesKey;

	[FieldOffset(16)]
	public int ArmourMin;

	[FieldOffset(20)]
	public int ArmourMax;

	[FieldOffset(24)]
	public int EvasionMin;

	[FieldOffset(28)]
	public int EvasionMax;

	[FieldOffset(32)]
	public int EnergyShieldMin;

	[FieldOffset(36)]
	public int EnergyShieldMax;

	[FieldOffset(40)]
	public int IncreasedMovementSpeed;

	[FieldOffset(44)]
	public int WardMin;

	[FieldOffset(48)]
	public int WardMax;

	[FieldOffset(52)]
	public int Unk010;

	[FieldOffset(56)]
	public int Unk011;

}
