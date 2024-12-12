namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ClientStrings
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference Text;

	[FieldOffset(16)]
	public StringReference XBoxText;

	[FieldOffset(24)]
	public StringReference XBoxText2;

	[FieldOffset(32)]
	public int HASH32;

	[FieldOffset(36)]
	public StringReference PlaystationText;

}
