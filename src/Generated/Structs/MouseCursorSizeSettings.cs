namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MouseCursorSizeSettings
{
	[FieldOffset(0)]
	public StringReference Size;

	[FieldOffset(8)]
	public StringReference Description;

	[FieldOffset(16)]
	public float Ratio;

}
