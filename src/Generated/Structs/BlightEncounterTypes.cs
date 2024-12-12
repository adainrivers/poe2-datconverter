namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BlightEncounterTypes
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference Icon;

	[FieldOffset(16)]
	public TBool IsGeneric;

	[FieldOffset(17)]
	public int Weight;

}
