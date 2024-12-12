namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HellscapeAOReplacements
{
	[FieldOffset(0)]
	public StringReference Original;

	[FieldOffset(8)]
	public int HASH32;

	[FieldOffset(12)]
	public StringReference Replacement;

}
