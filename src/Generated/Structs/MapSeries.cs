using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MapSeries
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Name;

	[FieldOffset(16)]
	public TString BaseIcon_DDSFile;

	[FieldOffset(24)]
	public TString Infected_DDSFile;

	[FieldOffset(32)]
	public TString Shaper_DDSFile;

	[FieldOffset(40)]
	public TString Elder_DDSFile;

	[FieldOffset(48)]
	public TString Drawn_DDSFile;

	[FieldOffset(56)]
	public TString Delirious_DDSFile;

	[FieldOffset(64)]
	public TString UberBlight_DDSFile;

	[FieldOffset(72)]
	public TString Purple_DDSFile;

}
