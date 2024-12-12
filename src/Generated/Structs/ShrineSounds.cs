namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ShrineSounds
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference StereoSoundFile;

	[FieldOffset(16)]
	public StringReference MonoSoundFile;

}
