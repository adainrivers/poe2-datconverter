namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AtlasMemoryLine
{
	[FieldOffset(0)]
	public StringReference League;

	[FieldOffset(8)]
	public StringReference League2;

	[FieldOffset(16)]
	public StringReference StartPointArt;

	[FieldOffset(24)]
	public StringReference MidPointArt;

	[FieldOffset(32)]
	public StringReference EndPointArt;

	[FieldOffset(40)]
	public StringReference PathArt;

}
