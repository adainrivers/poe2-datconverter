namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct CharacterTextAudio
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference Text;

	[FieldOffset(16)]
	public StringReference SoundFile;

	[FieldOffset(24)]
	public StringReference ParrotSoundFile;

	[FieldOffset(32)]
	public int Unk004;

}
