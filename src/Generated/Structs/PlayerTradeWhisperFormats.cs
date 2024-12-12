namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct PlayerTradeWhisperFormats
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference Whisper;

	[FieldOffset(16)]
	public TBool InStash;

	[FieldOffset(17)]
	public TBool IsPriced;

}
