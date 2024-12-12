namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SynthesisGlobalMods
{
	[FieldOffset(0)]
	[ReferenceTable("Mods")]
	public TableReference ModsKey;

	[FieldOffset(16)]
	public int Weight;

	[FieldOffset(20)]
	public int MinLevel;

	[FieldOffset(24)]
	public int MaxLevel;

}
