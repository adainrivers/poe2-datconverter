namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MapSeries
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference Name;

	[FieldOffset(16)]
	public StringReference BaseIcon_DDSFile;

	[FieldOffset(24)]
	public StringReference Infected_DDSFile;

	[FieldOffset(32)]
	public StringReference Shaper_DDSFile;

	[FieldOffset(40)]
	public StringReference Elder_DDSFile;

	[FieldOffset(48)]
	public StringReference Drawn_DDSFile;

	[FieldOffset(56)]
	public StringReference Delirious_DDSFile;

	[FieldOffset(64)]
	public StringReference UberBlight_DDSFile;

	[FieldOffset(72)]
	public StringReference Purple_DDSFile;

}
