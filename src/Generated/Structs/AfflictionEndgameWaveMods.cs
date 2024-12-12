namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AfflictionEndgameWaveMods
{
	[FieldOffset(0)]
	[ReferenceTable("Mods")]
	public TableReference ModsKey;

	[FieldOffset(16)]
	public int Unk001;

	[FieldOffset(20)]
	public int Unk002;

	[FieldOffset(24)]
	public int Unk003;

}
