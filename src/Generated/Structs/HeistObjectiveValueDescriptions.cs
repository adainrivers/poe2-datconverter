namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HeistObjectiveValueDescriptions
{
	[FieldOffset(0)]
	public int Tier;

	[FieldOffset(4)]
	public float MarkersMultiply;

	[FieldOffset(8)]
	public StringReference Description;

}
