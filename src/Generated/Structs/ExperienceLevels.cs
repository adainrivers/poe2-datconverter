namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ExperienceLevels
{
	[FieldOffset(0)]
	public StringReference Unk000;

	[FieldOffset(8)]
	public int Level;

	[FieldOffset(12)]
	public uint Experience;

}
