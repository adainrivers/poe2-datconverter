namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SocketNotches
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference Description;

	[FieldOffset(16)]
	public StringReference RedSocketImage;

	[FieldOffset(24)]
	public StringReference BlueSocketImage;

	[FieldOffset(32)]
	public StringReference GreenSocketImage;

}
