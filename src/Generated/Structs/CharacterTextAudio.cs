using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct CharacterTextAudio
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Text;

	[FieldOffset(16)]
	public TString SoundFile;

	[FieldOffset(24)]
	public TString ParrotSoundFile;

	[FieldOffset(32)]
	public int Unk004;

}
