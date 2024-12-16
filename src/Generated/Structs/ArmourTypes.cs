namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ArmourTypes
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference BaseItemTypesKey;

	[FieldOffset(16)]
	public int Armour;

	[FieldOffset(20)]
	public int EvasionRating;

	[FieldOffset(24)]
	public int EnergyShield;

	[FieldOffset(28)]
	public int Unk02;

	[FieldOffset(32)]
	public int Unk03;

	[FieldOffset(36)]
	public int Unk04;

	//[FieldOffset(40)]
	//public int IncreasedMovementSpeed;

	//[FieldOffset(44)]
	//public int WardMin;

	//[FieldOffset(48)]
	//public int WardMax;

	//[FieldOffset(52)]
	//public int Unk010;

	//[FieldOffset(56)]
	//public int Unk011;

}
