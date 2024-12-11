using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct PlayerTradeWhisperFormats
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Whisper;

	[FieldOffset(16)]
	public TBool InStash;

	[FieldOffset(17)]
	public TBool IsPriced;

}
