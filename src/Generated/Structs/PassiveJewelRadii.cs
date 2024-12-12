namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct PassiveJewelRadii
{
	[FieldOffset(0)]
	public StringReference ID;

	[FieldOffset(8)]
	public int RingOuterRadius;

	[FieldOffset(12)]
	public int RingInnerRadius;

	[FieldOffset(16)]
	public int Radius;

}
