namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SoundEffects
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference SoundFile;

	[FieldOffset(16)]
	public StringReference SoundFile_2D;

	[FieldOffset(24)]
	public TBool Unk003;

	[FieldOffset(25)]
	public StringReference Unk004;

}
